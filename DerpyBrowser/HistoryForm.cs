using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerpyBrowser
{
    public partial class HistoryForm : Form
    {

        private List<HistoryAddress> history;
        private List<Tab> tabs;
        private Tab currentTab;
        private string homePage;

        public HistoryForm(List<HistoryAddress> history, List<Tab> tabs,  Tab currentTab, string homePage)
        {
            InitializeComponent();
            this.history = history;
            this.tabs = tabs;
            this.currentTab = currentTab;
            this.homePage = homePage;
            listBox1.MultiColumn = true;
            foreach(Address add in history)
            {
                listBox1.Items.Add(add.getUri());
            }
        }

        private void setCurrentTab(Tab tab)
        {
            currentTab = tab;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            currentTab.navigate(listBox1.SelectedItem.ToString());
        }

        
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.X, e.Y);
                if (listBox1.SelectedItems.Count > 0)
                {
                    rightClickMenu.Show(this, new Point(e.X, e.Y));
                }
            }
        }
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rightClickMenu.Hide();
            removeFromHistory((string)listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        //remove history item from master and all tab histories
        public void removeFromHistory(string uri)
        {
            foreach (HistoryAddress add in history)
            {
                if (add.getUri().Equals(uri))
                {
                    history.Remove(add);
                    break;
                }
            }
            foreach (Tab tab in tabs)
            {
                foreach (HistoryAddress add in tab.getTabHistory())
                {
                    if (add.getUri().Equals(uri))
                    {
                        tab.getTabHistory().Remove(add);
                        break;
                    }

                }
                if (tab.getTabHistory().Count < 1) tab.getTabHistory().Add(new HistoryAddress(homePage));       //never empty tab history
                tab.recalculateHistoryPoint(tab.getUri());                                                      //recalculate history point
            }

        }
    }
}
