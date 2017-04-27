using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripProj.Business.Interfaces
{
    public interface IDIContainer
    {
        object Get(Type typeBeforeMapping);

        void MapInstance<TTypeBeforeMapping, TTypeToMapTo>();
    }
}
