using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace SongDataBase
{
    public class Song
    {
        private const int _defaultAmount = 10;
        public static int TotalAmount { get; set; }
        public Song()
        {
            CheckList();
        }
        void CheckList()
        {
            if (TotalAmount >= _defaultAmount)
            {
                // NotifyCollectionChangedAction; 
            }
        }       
        void NotifyOverCrowded()
        {
            //Notify a driver go to main Site
        }
}
