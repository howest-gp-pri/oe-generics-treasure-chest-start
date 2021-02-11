using System;
using System.Collections.Generic;
using System.Text;

namespace TreasureChest.Cons.Core.Domain
{
    public class TreasureChest<T> where T : class
    {
        private readonly T _item;
        public TreasureChest(T item)
        {
            _item = item;
        }

        public string RevealContent()
        {
            return _item.ToString();
        }
    }
}
