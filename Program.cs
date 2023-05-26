﻿using System;
using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$; TrustServerCertificate=True";
        // Aqui a CONNECTION_STRING está disponível para todos os métodos, private para ser acessível somente pelo program
        private static void Main(string[] args)
        {
            // ReadUsers();
            // ReadUser();
            // CreatUser();
            // UpdateUser();
            // DeleteUser();
        }

        public static void ReadUsers()
        {
            var repository = new UserRepository();
            var users = repository.Get();
            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }
        public static void ReadUser()

        {
            Console.Clear();
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1); // Listar (SELECT * FROM) todos os usuários da base
                Console.WriteLine(user.Name);
            }
        }

        public static void CreatUser()

        {
            var user = new User()
            {
                Bio = "Equipe balta.io",
                Email = "hello@balta.io",
                Image = "https://...",
                Name = "Equipe balta.io",
                PasswordHash = "HASH",
                Slug = "equipe-balta"
            };
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
                Console.WriteLine("Cadastro realizado com sucesso");
            }
        }

        public static void UpdateUser()

        {
            var user = new User()
            {
                Id = 2,
                Bio = "Equipe | balta.io",
                Email = "hello@balta.io",
                Image = "https://...",
                Name = "Equipe de suporte balta.io",
                PasswordHash = "HASH",
                Slug = "equipe-balta"
            };
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);
                Console.WriteLine("Atualização realizada com sucesso");
            }
        }

        public static void DeleteUser()

        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(2);
                connection.Delete<User>(user);
                Console.WriteLine("Exclusão realizada com sucesso");
            }
        }
    }
}
