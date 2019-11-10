using System;
using System.Collections.Generic;
using System.Text;
using Grabble.Data.Domain;
using Grabble.Repository.Interface;

namespace Grabble.Service
{
    public class FamiliarService : IFamiliarService
    {
        private IRepository<Familiar> familiarRespository;

        public FamiliarService(IRepository<Familiar> familiarrepository)
        {
            this.familiarRespository = familiarrepository;
        }
        public void DeleteFamiliar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Familiar> GetFamiliar()
        {
            return familiarRespository.GetAll();
        }

        public Familiar GetFamiliar(int id)
        {
            return familiarRespository.Get(id);
        }

        public void InsertFamiliar(Familiar familiar)
        {
            familiarRespository.Insert(familiar);
        }

        public void UpdateFamiliar(Familiar familiar)
        {
            familiarRespository.Update(familiar);
        }
    }
}
