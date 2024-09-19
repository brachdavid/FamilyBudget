using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget
{
    /// <summary>
    /// Abstraktní třída EntityBase slouží jako základ pro entity s unikátními ID
    /// </summary>
    /// <typeparam name="T">Typ entity, která dědí z EntityBase</typeparam>
    public abstract class EntityBase<T> where T : EntityBase<T>
    {
        /// <summary>
        /// Poslední použité ID, používá se k unikátnímu číslování entit
        /// </summary>
        private static int _lastId = 0;

        /// <summary>
        /// Unikátní ID pro každou entitu
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Konstruktor pro automatické generování ID
        /// </summary>
        protected EntityBase()
        {
            Id = ++_lastId;
        }
    }
}
