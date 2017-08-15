using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace DerpyBrowser
{
    /*
     * Main program window class.
     * This class contains all main GUI elements and handler functions.
     */
    public partial class Form1 : Form
    {

        //**********variables**********                            
        public List<HistoryAddress> MasterHistory = new List<HistoryAddress>();               //master history list
        public List<FavouriteAddress> Favourites = new List<FavouriteAddress>();              //favourites list
        public List<Tab> tabs = new List<Tab>();                                              //tabs list
        public string homePage = "http://www.google.com/";                                    //homepage, google by default
        public Tab currentTab;                                                                //current active tab in browser





        //constructor
        public Form1()
        {
            InitializeComponent();

            Stream stream;
            try
            {
                stream = File.Open("userdata", FileMode.Open);                          //load user data
                BinaryFormatter formatter = new BinaryFormatter();
                UserData userdata = (UserData)formatter.Deserialize(stream);
                stream.Close();

                MasterHistory = userdata.getHistory();                                  //set variables from user data
                Favourites = userdata.getFaves();
                homePage = userdata.getHome();

                openTab(homePage);                                                      //populate browser window
                urlBox.Text = homePage;
            }
            catch(FileNotFoundException)
            {
                openTab(homePage);                                                      //populate browser window from default values
                urlBox.Text = homePage;
            }
        }



        //**********tab functions**********
        public void openTab(string uri) //opens a new browser tab
        {
            TabPage page = new TabPage();                   //create tab page
            tabsContainer.TabPages.Add(page);               //add page to tab container

            TextBox textbox = new TextBox();                //create and setup output text box
            textbox.Multiline = true;
            textbox.ReadOnly = true;
            textbox.ScrollBars = ScrollBars.Both;
            textbox.Size = new Size(tabsContainer.Size.Width - 10, tabsContainer.Size.Height);
            textbox.Text = "Loading Page...";
            page.Controls.Add(textbox);                     

            currentTab = new Tab(uri, MasterHistory, Favourites, urlBox, textbox, tabsContainer.TabPages.IndexOf(page)); //create new tab and set it to current
            tabs.Add(currentTab);                           //add tab to tabs list
        }

        //closes input tab
        public void closeTab(Tab t) 
        {
            if (tabs.Count > 1)                                                             //don't remove the last tab
            {
                tabs.Remove(t);                                                             //remove tab from tab list
                tabsContainer.TabPages.RemoveAt(t.getIndex());                              //remove relevant tab page from GUI
                for (int i = 0; i < tabs.Count(); i++) tabs[i].setIndex(i);                 //re-assign tab indexes
                if (t.Equals(currentTab)) currentTab = tabs[tabsContainer.SelectedIndex];   //set current tab
            }
        }

        //handles tab switching
        private void tabsContainer_Selected(object sender, TabControlEventArgs e)
        {
            currentTab = tabs.ElementAt(tabsContainer.SelectedIndex);       //set current tab to correct object
            urlBox.Text = currentTab.getUri();                              //update url box
        }

        //tab button handlers
        private void newTabButton_Click(object sender, EventArgs e)
        {
            openTab(homePage);                                              //call openTab function
            tabsContainer.SelectTab(tabsContainer.TabCount - 1);            //open the new tab on the GUI
        }

        private void closeTabButton_Click(object sender, EventArgs e)
        {
            closeTab(currentTab);                                           //call closeTab function
        }





        //**********url box functions**********
        //event handlers
        private void urlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                currentTab.navigateNewPage(checkUri(urlBox.Text));
            }
        }
        private void navigateButton_Click(object sender, EventArgs e)
        {
            currentTab.navigateNewPage(checkUri(urlBox.Text));
        }

        //handle shortened uri strings
        private string checkUri(string uri)
        {
            if (!Regex.Match(uri, "http://www.*").Success)                  
            {
                if (Regex.Match(uri, "www.*").Success)
                {
                    uri = "http://" + uri;
                }
                else uri = "http://www." + uri;
            }
            return uri;
        }



        //**********home button functions**********
        private void homeButton_Click(object sender, EventArgs e)
        {
            currentTab.navigate(homePage);
            urlBox.Text = homePage;
        }

        private void homeButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                homeMenu.Show(this, new Point(e.X, e.Y));
            }
        }

        private void setCurrentPageAsHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeMenu.Hide();
            homePage = urlBox.Text;
        }



        //**********history functions**********

        //button handler
        private void button1_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(MasterHistory, tabs, currentTab, homePage);
            historyForm.Show();
        }






        //**********back button functions**********

        //left click handler
        private void backButton_Click(object sender, EventArgs e)
        {
            currentTab.back();
        }

        //right click handler
        private void backButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                backMenu.Items.Clear();
                int p = currentTab.getHistoryPoint();
                for (int i = 0; i <= p; i++)
                {
                    backMenu.Items.Add(currentTab.getTabHistory()[i].getUri());
                }
                backMenu.Show(MousePosition);
            }
        }

        //goto history item
        private void backMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            currentTab.navigate(e.ClickedItem.Text);
            urlBox.Text = e.ClickedItem.Text;
        }






        //**********forward button functions**********

        //left click handler
        private void forwardButton_Click(object sender, EventArgs e)
        {
            currentTab.forward();
        }

        //right click handler
        private void forwardButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                forwardMenu.Items.Clear();
                int p = currentTab.getTabHistory().Count - 1;
                for (int i = currentTab.getHistoryPoint(); i <= p; i++)
                {
                    forwardMenu.Items.Add(currentTab.getTabHistory()[i].getUri());
                }
                forwardMenu.Show(MousePosition);
            }
        }

        //go to history item
        private void forwardMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            currentTab.navigateNewPage(e.ClickedItem.Text);
            urlBox.Text = e.ClickedItem.Text;
        }





        //**********favorite functions**********
        private void addFaveButton_Click(object sender, EventArgs e)
        {
            addFaveMenu.Show(MousePosition);
            nameBox.Text = "Name your favourite here";
            nameBox.SelectAll();
        }

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                bool dupe = false;
                foreach (FavouriteAddress add in Favourites)
                {
                    if (add.getName().Equals(nameBox.Text))
                    {
                        nameBox.Text = "That name is already taken, please try again.";
                        nameBox.SelectAll();
                        dupe = true;
                        break;
                    }
                }
                if (!dupe) { 
                    Favourites.Add(new FavouriteAddress(currentTab.getUri(), nameBox.Text));
                    nameBox.Text = "";
                    addFaveMenu.Hide();
                }
            }
        }


        private void favoritesButton_Click(object sender, EventArgs e)
        {
            FavoriteForm faveForm = new FavoriteForm(Favourites, currentTab);
            faveForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserData user = new UserData(MasterHistory, Favourites, homePage);
            Stream stream = File.Open("userdata", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, user);
            stream.Close();
        }
    }
}
