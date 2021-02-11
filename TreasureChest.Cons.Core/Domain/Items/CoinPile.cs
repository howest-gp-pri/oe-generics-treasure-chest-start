using System;
using System.Collections.Generic;
using System.Text;

namespace TreasureChest.Cons.Core.Domain.Items
{
    public enum CoinType { Silver, Gold, Copper, Bronze }
    public class CoinPile : ItemBase
    {
        public CoinPile(double valueInEuro, int numberOfCoins, CoinType coinType) : base(valueInEuro)
        {
            NumberOfCoins = numberOfCoins;
            CoinType = coinType;
        }
        public int NumberOfCoins { get; private set; }
        public CoinType CoinType { get; private set; }

        public override string ToString()
        {
            return $"A pile of {NumberOfCoins} {CoinType} coins, worth {ValueInEuro} euros!";
        }
    }
}
