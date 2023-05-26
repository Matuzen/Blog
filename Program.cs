using System;
using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";
        // Aqui a CONNECTION_STRING está disponível para todos os métodos, private para ser acessível somente pelo program
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>(); // Listar todos os usuários da base
                foreach (var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }
        }
    }
}
