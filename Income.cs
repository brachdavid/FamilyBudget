using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    public class Income : EntityBase<Income>, ITransaction
    {
        public string ItemName { get; private set; }
        public double ItemValue { get; private set; }

        public Income(string itemName, double itemValue)
        {
            ItemName = itemName;
            ItemValue = itemValue; 
        }
        public override string ToString()
        {
            return $"Id: {Id}\t\tItem name: {ItemName}\t\tItem value: {ItemValue} Kč";
        }
    }
}
