using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IGenericRepository
    {
        void Save(IEntity entity);
        void Update(IEntity entity);    
        List<IEntity> GetAll(IEntity entity);
        List<IEntity> GetAllWithCondition(IEntity entity);
        void Delete(IEntity entity);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
