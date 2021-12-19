using Decorator.Beverage;
using System.Collections.Generic;
using System.Linq;

namespace Decorator.Condiment
{
    abstract class CondimentDecorator : BeverageBase
    {
        public abstract decimal CalculatePrice();

        public virtual string GetFullDescription()
        {
            string fullDescription = "";
            Dictionary<string, int> beverageDict = new Dictionary<string, int>();

            BeverageBase temp = this;

            // count number of each beverage ordered
            while(temp != null)
            {
                if (beverageDict.ContainsKey(temp.Description))
                {
                    beverageDict[temp.Description]++;
                }
                else
                {
                    beverageDict.Add(temp.Description, 1);
                }

                temp = temp.Beverage;
            }

            // Iterate over items in reverse order to keep
            // the initial order
            foreach(KeyValuePair<string, int> kvp in beverageDict.Reverse())
            {
                // If it's first item, we don't need ',' before
                // adding it to the description
                if (string.IsNullOrEmpty(fullDescription))
                {
                    fullDescription = $"{kvp.Value}{(kvp.Value > 1 ? "x" : "")} {kvp.Key}";
                }
                else
                {
                    // If the item was ordered more than once
                    // add "x" after it's count
                    fullDescription += $", {kvp.Value}{(kvp.Value > 1 ? "x" : "" )} {kvp.Key}";
                }
            }

            return fullDescription;
        }
    }
}
