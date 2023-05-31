using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class Repository<T> where T : class  
                // Só será aceito a criação de repositórios genéricos de algum tipo onde esse tipo seja uma classe
    {
         private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
           => _connection = connection;
        public IEnumerable<T> Get()
           => _connection.GetAll<T>();
    }
}