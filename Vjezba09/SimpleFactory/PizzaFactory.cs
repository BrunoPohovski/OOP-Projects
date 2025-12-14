using System.Collections.Generic;

namespace SimpleFactory
{
    public static class PizzaFactory
    {
            public static Pizza CreateMargherita()
            {
                var listOfIngredients = new List<Pizza.Ingredient>
                {
                    Pizza.Ingredient.Cheese,
                    Pizza.Ingredient.Tomato
                };
                return new Pizza("Margherita", 8.99, listOfIngredients);
            }

            public static Pizza CreatePepperoni()
            {
                var listOfIngredients = new List<Pizza.Ingredient>
                {
                    Pizza.Ingredient.Cheese,
                    Pizza.Ingredient.Pepperoni,
                    Pizza.Ingredient.Tomato
                };
                return new Pizza("Pepperoni", 10.99, listOfIngredients);
            }
            
            public static Pizza CreateSalami()
            {
                var listOfIngredients = new List<Pizza.Ingredient>
                {
                    Pizza.Ingredient.Cheese,
                    Pizza.Ingredient.Tomato,
                    Pizza.Ingredient.Salami
                };
                return new Pizza("Salami", 11.99, listOfIngredients);
            }
    }
}