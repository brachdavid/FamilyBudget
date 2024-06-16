using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    public class Expense : EntityBase<Expense>
    {
        public string ItemName { get; private set; }
        public double ItemValue { get; private set; }
        public Expense(string itemValue, double amount) 
        {
            ItemName = itemValue;
            ItemValue = amount;
        }
        public override string ToString()
        {
            return $"Id: {Id}\tItem name: {ItemName}\tItem value: {ItemValue} Kč";
        }
    }
}
