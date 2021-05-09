using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; internal set; }
    }
}
