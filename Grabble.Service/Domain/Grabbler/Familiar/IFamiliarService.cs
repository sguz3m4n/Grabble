using System.Collections.Generic;
using Grabble.Data.Domain;

namespace Grabble.Service
{
    public interface IFamiliarService
    {
        IEnumerable<Familiar> GetFamiliar();
        Familiar GetFamiliar(int id);
        void InsertFamiliar(Familiar familiar);
        void UpdateFamiliar(Familiar familiar);
        void DeleteFamiliar(int id);
    }
}
