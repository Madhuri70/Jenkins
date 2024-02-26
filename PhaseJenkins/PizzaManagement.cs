using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseJenkins
{
    public class PizzaManagement
    {
        static List<Pizza> pizzas = new List<Pizza>
        {
            new Pizza { Id =1, Name="Panner Pizza",Price=600},
            new Pizza { Id =2, Name="Mushroom Pizza",Price=750},

        }; public List<Pizza> AllPizzas()
        {
            return pizzas;
        }
    }
}

