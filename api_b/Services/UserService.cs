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

        public UserService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("tp4"));
            var database = client.GetDatabase("tp4");
            _users = database.GetCollection<User>("users");
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
            return user;
        }
    }
}
