﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itHappends;
using itHappens.UIs.Common;

namespace itHappens.Classes
{
    class madeForYouCarousel
    {
        public List<CategoryGroupBox> GroupBox = new List<CategoryGroupBox>();
        public madeForYouCarousel(bool logged)
        
        {
            if (logged)
                LoggedInUser(10);
            else
                LoggedOutUser(10);
        }

        private void LoggedInUser(int size)
        {
             //den exw tropo na parw ton loged in user
            
                List<List<string>> Categories = Db_connector.Readrows(Db_connector.Categories(size), new int[] { 2, 3 });
                for (int i = 0; i < size; i++)
                {
                    GroupBox.Add(new CategoryGroupBox(Categories[i][0], Categories[i][1]));
                }
            
        }
        private void LoggedOutUser(int size)
        {
            var query = Db_connector.Categories(size);
            List<List<string>> Categories = Db_connector.Readrows(query,new int[] {0,1} );
            for (int i=0; i < size; i++)
            {
               GroupBox.Add(new CategoryGroupBox(Categories [i] [0] , Categories[i][1]));
            }
            
        }



        
    }
}
