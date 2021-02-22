using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private DateTime dateOfLaunch;

        public DateTime DateOfLaunch
        {
            get { return dateOfLaunch; }
            set { dateOfLaunch = value; }
        }

        private bool active;

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private bool freeDelivery;

        public bool FreeDelivery
        {
            get { return freeDelivery; }
            set { freeDelivery = value; }
        }
        public MenuItem()
        {

        }

        public MenuItem(int id, string name , float price, bool active,
            DateTime dateOfLaunch, string category, bool freeDelivery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.active = active;
            this.dateOfLaunch = dateOfLaunch;
            this.category = category;
            this.freeDelivery = freeDelivery;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }

}
