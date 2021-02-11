using System;
using System.Collections.Generic;
using System.Text;

namespace TreasureChest.Cons.Core.Domain.Items
{
    public class Diamond : ItemBase
    {
        public bool IsCut { get; private set; }
        public int Faces { get; private set; }

        public Diamond(double valueInEuro, bool isCut, int numberOfFaces) : base(valueInEuro)
        {
            IsCut = isCut;
            Faces = numberOfFaces;
        }

        public override string ToString()
        {
            return $"A diamond that is worth {ValueInEuro} euro!";
        }
    }
}
