using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizzaProject
{
    /// <summary>
    /// Model a pizza that's been ordered at LaRosa's
    /// </summary>
    internal class Pizza
    {
        public enum size {Undefined, Small, Medium, Large, X_Large };
        private size pizzaSize;
        private List<String> toppings;
        /// <summary>
        /// The size of the pizza
        /// </summary>
        size Size {
            get { return  pizzaSize; }
            set { pizzaSize = value; }
        }
        /// <summary>
        /// Initialize a Pizza
        /// </summary>
        public Pizza()
        {
            // Create an empty list of toppings for this new Pizza object
            toppings = new List<String>();
            Size = size.Undefined;
        }
        /// <summary>
        /// Bake the pizza 
        /// </summary>
        public void Bake()
        {
            Console.WriteLine("Baking the pizza...");
        }
        /// <summary>
        /// Add a topping to the Pizza
        /// </summary>
        /// <param name="topping">The topping to be added</param>
        public void AddTopping(String topping)
        {
            toppings.Add(topping);
        }
        public override String ToString()
        {
            return "Size: " + Size.ToString() + "Toppings: " + toppings.ToString();
        }
    }
}
