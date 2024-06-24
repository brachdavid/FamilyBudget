using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    public interface ITransaction
    {
        string ItemName { get; }
        double ItemValue { get; }
        int Id { get; }
    }
}
