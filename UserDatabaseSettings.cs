namespace test1_webapi{

    public class UserDatabaseSetting : IUserDatabaseSetting {
        public string UserCollectionName { get; set;}
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IUserDatabaseSetting {
        string UserCollectionName { get; set;}
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}