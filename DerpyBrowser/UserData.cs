using System;
using System.Collections.Generic;

namespace DerpyBrowser
{
    [Serializable()]
    public class UserData
    {
        private List<HistoryAddress> MasterHistory;             //master history list
        private List<FavouriteAddress> Favourites;              //favourites list
        private string homePage;                                //home page

        public UserData(List<HistoryAddress> MasterHistory, List<FavouriteAddress> Favourites, string homePage)
        {
            this.MasterHistory = MasterHistory;
            this.Favourites = Favourites;
            this.homePage = homePage;
        }

        //setters
        public void setHistory(List<HistoryAddress> MasterHistory)
        {
            this.MasterHistory = MasterHistory;
        }

        public void setFaves(List<FavouriteAddress> Favourites)
        {
            this.Favourites = Favourites;
        }

        public void setHome(String homePage)
        {
            this.homePage = homePage;
        }

        //getters
        public List<HistoryAddress> getHistory()
        {
            return MasterHistory;
        }

        public List<FavouriteAddress> getFaves()
        {
            return Favourites;
        }

        public string getHome()
        {
            return homePage;
        }
    }
}
