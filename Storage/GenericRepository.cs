using DatabaseBroker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class GenericRepository : IGenericRepository
    {
        private Broker broker = new Broker();
        public void OpenConnection()
        {
            broker.OpenConnection();
        }
        public void CloseConnection()
        {
            broker.CloseConnection();
        }
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }
        public void Commit()
        {
            broker.Commit();
        }
        public void Rollback()
        {
            broker.Rollback();
        }
        public void Save(IEntity entity)
        {
            broker.Save(entity);
        }
        public void Update(IEntity entity)
        {
            broker.Update(entity);  
        }
        public void Delete(IEntity entity)
        {
            broker.Delete(entity);
        }
        public List<IEntity> GetAll(IEntity entity)
        {
            return broker.GetAll(entity);
        }
        public List<IEntity> GetAllWithCondition(IEntity entity)
        {
            return broker.GetAllWithCondition(entity);
        }

        public List<IEntity> GetSpecific(IEntity entity)
        {
            return broker.GetSpecific(entity);
        }
    }
}
