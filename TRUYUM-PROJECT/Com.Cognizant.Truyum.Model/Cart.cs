using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class Cart
    {
        private List<MenuItem> menuItemList;

        public List<MenuItem> MenuItemList
        {
            get { return menuItemList; }
            set { menuItemList = value; }
        }

        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        // Add constructors here

    }

}
