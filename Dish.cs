using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishMakerAbstractFactory
{
    abstract class Dish
    {
        public List<Ingredient> Ingredients;

        public Dish()
        {
            Ingredients = CreateIngredientsList();
        }
        public abstract List<Ingredient> CreateIngredientsList();
        public abstract void GetRecipe();
    }

    class CheeseSandwich : Dish
    {
        public override List<Ingredient> CreateIngredientsList()
        {
            List<Ingredient> list = new List<Ingredient>();
            list.Add(new Bread("2 kromki"));
            list.Add(new Cheese("2 plasterki"));
            list.Add(new Lettuce("2 liście"));
            list.Add(new Tomato("2 plasterki"));
            return list;
        }

        public override void GetRecipe()
        {
            Console.WriteLine("Kanapka z serem: ");
            foreach (var ingredient in this.Ingredients)
            {
                ingredient.GetIngredient();
            }
        }
    }

    class MargheritaPizza : Dish
    {
        public override List<Ingredient> CreateIngredientsList()
        {
            List<Ingredient> list = new List<Ingredient>();
            list.Add(new Flour("1 szklanka"));
            list.Add(new WarmWater("0.5 szklanki"));
            list.Add(new Yeast("5 g"));
            list.Add(new OliveOil("2 łyżki"));
            list.Add(new Salt("0.5 łyżeczki"));
            list.Add(new Mozzarella("100 g"));
            list.Add(new Tomato("140 g"));
            list.Add(new Basil("1 garść"));
            list.Add(new Oregano("1/3 łyżeczki"));
            list.Add(new Oregano("1 ząbek"));
            return list;
        }

        public override void GetRecipe()
        {
            Console.WriteLine("Pizza margherita: ");
            foreach (var ingredient in this.Ingredients)
            {
                ingredient.GetIngredient();
            }
        }
    }
}
