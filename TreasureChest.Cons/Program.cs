using System;
using TreasureChest.Cons.Core.Domain;
using TreasureChest.Cons.Core.Domain.Items;

namespace TreasureChest.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ahoy! Create your treasure chests here.
            //Dit moet werken ...
            Gem ruby = new Gem(100, "Ruby");
            TreasureChest<Gem> gemChest = new TreasureChest<Gem>(ruby);
            string gemChestContent = gemChest.RevealContent();
            Console.WriteLine(gemChestContent);

            //... maar dit ook ...
            Diamond diamond = new Diamond(7500, true, 9);
            TreasureChest<Diamond> diamondChest = new TreasureChest<Diamond>(diamond);
            string diamondChestContent = diamondChest.RevealContent();
            Console.WriteLine(diamondChestContent);
        }

    }
}
