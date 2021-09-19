
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace test1_webapi {
    public class UserService {
        private readonly IMongoCollection<UserModel> _user;

        public UserService(IUserDatabaseSetting setting){
            var client = new MongoClient(setting.ConnectionString);
            var database = client.GetDatabase(setting.DatabaseName);

            _user = database.GetCollection<UserModel>(setting.UserCollectionName);
        }

        public List<UserModel> Get() => _user.Find(user => true).ToList();

        public UserModel Create(UserModel user){
            _user.InsertOne(user);
            return user;
        }
        
    }
}