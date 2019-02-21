using api_b.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace api_b.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;
        private readonly IMongoCollection<User> _usersP;

        public UserService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("tp4"));
            var database = client.GetDatabase("tp4");
            _users = database.GetCollection<User>("users");

            var clientP = new MongoClient(config.GetConnectionString("tp4p"));
            var databaseP = clientP.GetDatabase("tp4");
            _usersP = databaseP.GetCollection<User>("users");

        }

        public List<User> Get()
        {
            return _users.Find(users => true).ToList();
        }

        public User Get(string id)
        {
            return _users.Find(users => users.Id == id).FirstOrDefault();
        }

        public User Create(User user)
        {
            _users.InsertOne(user);
            _usersP.InsertOne(user);
            return user;
        }
    }
}
