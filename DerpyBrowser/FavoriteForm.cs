using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DerpyBrowser
{
    public partial class FavoriteForm : Form
    {

        private List<FavouriteAddress> Favourites;
        private Tab currentTab;

        //constructor
        public FavoriteForm(List<FavouriteAddress> Favourites, Tab currentTab)
        {
            InitializeComponent();
            this.Favourites = Favourites;
            this.currentTab = currentTab;
            foreach (FavouriteAddress add in Favourites)
            {
                listBox1.Items.Add(add);
            }
        }

        private void setCurrentTab(Tab tab)
        {
            currentTab = tab;
        }

        private void listBox1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            currentTab.navigate(((FavouriteAddress)listBox1.SelectedItem).getUri());
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.X, e.Y);
                if (listBox1.SelectedItems.Count > 0)
                {
                    rightClickMenu.Show(this, new Point(e.X, e.Y));
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e) //remove favorites
        {
            rightClickMenu.Hide();
            Favourites.Remove(Favourites.Find(delegate (FavouriteAddress add)
            {
                return add.getUri().Equals(listBox1.SelectedItem);
            }));
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void editTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameMenu.Show(MousePosition);
            nameBox.Text = "Enter name here";
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
                if (!dupe)
                {
                    FavouriteAddress add = (FavouriteAddress)listBox1.SelectedItem;
                    add.setName(nameBox.Text);
                    listBox1.Items.Remove(add);
                    listBox1.Items.Add(add);

                    nameBox.Text = "";
                    nameMenu.Hide();
                }
            }
        }
    }
}
