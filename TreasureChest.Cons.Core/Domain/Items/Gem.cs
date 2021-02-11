using System;
using System.Collections.Generic;
using System.Text;

namespace TreasureChest.Cons.Core.Domain.Items
{
    public class Gem : ItemBase
    {
        public Gem(double valueInEuro, string gemName) : base(valueInEuro)
        {
            Name = gemName;
        }
        public string Name { get; private set; } //Name of the gem (e.g.: Opal, Sapphire, Ruby, ...)

        public override string ToString()
        {
            return $"A gem ({Name}) that is worth {ValueInEuro} euro!";
        }
    }
}
