using System.Collections;
using System.Collections.Generic;

namespace CoffeeSh0p
{
    static class Controller
    {
        public static ArrayList coffeeList = new ArrayList();
        public static void AddInList(Coffee coffee)
        {
            coffeeList.Add(coffee);
        } 
        public static void RemoveFromList(Coffee coffee)
        {
            coffeeList.Remove(coffee);
        }
        public static ArrayList GetList()
        {
            return coffeeList;
        }

        
    }
}
