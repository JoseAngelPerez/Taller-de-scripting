using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelPerez
{
    public class ItemSlot
    {
        private int count;
       

        private Item item = new Item();

        

        public int Id
        {
            get { return item.Id; }
            set { item.Id = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

         public ItemSlot(int _count, string _nameItem, int _idItem, string _descriptionItem  )
        {
            count = _count;
            item = new Item(_nameItem, _idItem, _descriptionItem);
        }
            
    }
}
