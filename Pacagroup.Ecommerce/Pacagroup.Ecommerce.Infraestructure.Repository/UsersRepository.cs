using System;
using System.Collections.Generic;
using System.Text;
using Pacagroup.Ecommerce.Infraestructure.Interface;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Transversal.Common;
using Dapper;
using System.Data;

namespace Pacagroup.Ecommerce.Infraestructure.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public UsersRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public Users Authenticate(string username, string password) 
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "UsersGetByUserAndPassword";
                var parameters = new DynamicParameters();
                parameters.Add("UserName", username);
                parameters.Add("Password", password);

                var user = connection.QuerySingle<Users>(query, parameters, commandType: CommandType.StoredProcedure);
                return user;
            }
        }
    }
}
