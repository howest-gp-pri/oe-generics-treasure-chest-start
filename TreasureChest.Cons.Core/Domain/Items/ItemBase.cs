using System;
using System.Collections.Generic;
using System.Text;

namespace TreasureChest.Cons.Core.Domain.Items
{
    public abstract class ItemBase
    {
        public double ValueInEuro { get; private set; }

        public ItemBase(double valueInEuro)
        {
            ValueInEuro = valueInEuro;
        }
    }
}
