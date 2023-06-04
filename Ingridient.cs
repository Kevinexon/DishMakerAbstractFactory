using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishMakerAbstractFactory
{
    abstract class Ingredient
    {
        public string Quantity;

        public Ingredient(string quantity)
        {
            Quantity = quantity;
        }

        public abstract void GetIngredient();
    }


    class Tomato : Ingredient
    {
        public Tomato(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- pomidor " + Quantity);
        }
    }

    class Bread : Ingredient
    {
        public Bread(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- chleb " + Quantity);
        }
    }

    class Lettuce : Ingredient
    {
        public Lettuce(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- sałata " + Quantity);
        }
    }

    class Cheese : Ingredient
    {
        public Cheese(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- ser żółty " + Quantity);
        }
    }

    class Flour : Ingredient
    {
        public Flour(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- mąka " + Quantity);
        }
    }

    class WarmWater : Ingredient
    {
        public WarmWater(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- ciepła woda " + Quantity);
        }
    }

    class OliveOil : Ingredient
    {
        public OliveOil(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- oliwa z oliwek " + Quantity);
        }
    }

    class Yeast : Ingredient
    {
        public Yeast(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- drożdże " + Quantity);
        }
    }

    class Salt : Ingredient
    {
        public Salt(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- sól " + Quantity);
        }
    }

    class Mozzarella : Ingredient
    {
        public Mozzarella(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- mozzarella " + Quantity);
        }
    }

    class Basil : Ingredient
    {
        public Basil(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- bazylia " + Quantity);
        }
    }

    class Oregano : Ingredient
    {
        public Oregano(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- oregano " + Quantity);
        }
    }

    class Garlic : Ingredient
    {
        public Garlic(string quantity) : base(quantity)
        {
        }

        public override void GetIngredient()
        {
            Console.WriteLine("- czosnek " + Quantity);
        }
    }
}
