using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace DerpyBrowser
{
    /*
     * Tab Class
     */
    public class Tab
    {

        //**********variables**********
        private string currentUri;
        private List<HistoryAddress> TabHistory = new List<HistoryAddress>();
        private List<HistoryAddress> MasterHistory;
        private List<FavouriteAddress> Favourites;
        private TextBox urlBox;
        private TextBox textbox;
        private int currentHistoryPoint = -1;
        private int index;
        public delegate void changeText(string s);
        public changeText ct;





        //**********constructor**********
        public Tab(string uri, List<HistoryAddress> MasterHistory, List<FavouriteAddress> Favourites, TextBox urlBox, TextBox textbox, int index)
        {
            currentUri = uri;
            this.MasterHistory = MasterHistory;
            this.Favourites = Favourites;
            this.urlBox = urlBox;
            this.textbox = textbox;
            this.index = index;
            navigateNewPage(currentUri);
        }





        //**********navigation methods**********

        //navigate and add to history
        public void navigateNewPage(String uri)
        {
            addToHistory(uri);
            navigate(uri);
        }

        //navigation starter method
        public void navigate(string uri)
        {
            Thread t1 = new Thread(threadNav);                              //run navigation method on new thread
            t1.Start(uri);
            currentUri = uri;
            recalculateHistoryPoint(currentUri);
        }

        //navigation thread method
        public void threadNav(object obj)
        {

            lock (this)                                                     //lock the tab
            {
                string uri = (string)obj;                                   //cast input object to uri string

                try
                {
                    WebRequest request = WebRequest.Create(uri);            //create WebRequest using input uri
                    WebResponse response = request.GetResponse();           //get response
                    Stream dataStream = response.GetResponseStream();       //create dataStream on response
                    StreamReader reader = new StreamReader(dataStream);     //create StreamReader on dataStream
                    string responseFromServer = reader.ReadToEnd();         //create String from stream
                    ct = new changeText(updatePage);
                    ct.Invoke(responseFromServer);                          //invoke response into GUI
                    reader.Close();                                         //close up
                    response.Close();
                }
                catch (WebException ex)                                     //catch exceptions
                {
                    var resp = (HttpWebResponse)ex.Response;
                    switch (resp.StatusCode)
                    {
                        case HttpStatusCode.NotFound:                       //404
                            ct = new changeText(updatePage);
                            ct.Invoke("404 - Page Not Found");
                            break;
                        case HttpStatusCode.Forbidden:                      //403
                            ct = new changeText(updatePage);
                            ct.Invoke("403 - Forbidden");
                            break;
                        case HttpStatusCode.BadRequest:                     //400
                            ct = new changeText(updatePage);
                            ct.Invoke("400 - Bad Request");
                            break;
                    }
                }
            }
        }

        //invoke method to update GUI
        public void updatePage(string s)
        {
            textbox.Text = s;                                        
        }
        




        //**********button and event handlers**********
        public void back()
        {
            if (currentHistoryPoint > 0)                                                           //check if at start of history
            { 
                currentHistoryPoint--;                                                             //set history point to previous history address index
                string uri = TabHistory.ElementAt(currentHistoryPoint).getUri();
                navigate(uri);                                                                     //navigate to that address
                urlBox.Text = uri;                                                                 //update url box
            }
        }

        public void forward()
        {
            if (currentHistoryPoint < TabHistory.Count -1)                                         //check if at end of history
            {
                currentHistoryPoint++;                                                             //set history point to next history address index
                string uri = TabHistory.ElementAt(currentHistoryPoint).getUri();
                navigate(uri);                                                                     //and navigate to that address
                urlBox.Text = uri;                                                                 //update url box
            }
        }

        //adds items to master and tab histories upon opening new page
        public void addToHistory(string uri)
        {
            HistoryAddress add = new HistoryAddress(uri);                                          //create history address
            foreach(HistoryAddress item in MasterHistory)                                          
            {
                if (item.getUri().Equals(uri)) MasterHistory.Remove(item);                         //check for duplicates and remove them
                break;
            }
            MasterHistory.Add(add);                                                                //add to master history
            foreach (HistoryAddress item in TabHistory)
            {
                if (item.getUri().Equals(uri)) TabHistory.Remove(item);                            //check for duplicates and remove them
                break;
            }
            TabHistory.Add(add);                                                                   //add to tab history
        }

        //sets current history point to that of current history item via uri string
        public void recalculateHistoryPoint(string uri)
        {
            for(int i = 0; i < TabHistory.Count; i++)
            {
                if (TabHistory[i].getUri().Equals(uri))
                {
                    currentHistoryPoint = i;
                    break;
                }
            }
        }

        //getters and setters
        public string getUri()
        {
            return currentUri;
        }

        public int getIndex()
        {
            return index;
        }

        public void setIndex(int index)
        {
            this.index = index;
        }

        public List<HistoryAddress> getTabHistory()
        {
            return TabHistory;
        }

        public int getHistoryPoint()
        {
            return currentHistoryPoint;
        }
    }
}
