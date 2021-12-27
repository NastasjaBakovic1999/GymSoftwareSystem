using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        //ovo treba izmeniti, tj da ne bude hardcode-ovano
        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PSProjekat;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }
        public void Commit()
        {
            transaction?.Commit();
        }
        public void Rollback()
        {
            transaction?.Rollback();
        }
        public void Save(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"insert into {entity.TableName} values ({entity.InsertValues})";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Update(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"update {entity.TableName} set {entity.UpdateValues} where {entity.WhereCondition}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Delete(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"delete from {entity.TableName} where {entity.WhereCondition}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition}";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

        public List<IEntity> GetAllWithCondition(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} where {entity.GeneralCondition}";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

    }
}
