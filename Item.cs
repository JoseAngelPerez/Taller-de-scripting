using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelPerez
{
    public class Item
    {
        private string name;
        private int id;
        private string description;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Item()
        {

        }

        public Item (string _name, int _id, string _description)
        {
            Name = _name;
            Id = _id;
            Description = _description;
        }

    }
}
