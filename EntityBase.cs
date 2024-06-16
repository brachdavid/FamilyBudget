using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    public abstract class EntityBase<T> where T : EntityBase<T>
    {
        private static int _lastId = 0;

        public int Id { get; private set; }

        protected EntityBase()
        {
            Id = ++_lastId;
        }
    }
}
