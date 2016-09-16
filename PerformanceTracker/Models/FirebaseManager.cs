using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace PerformanceTracker.Models
{
    public class FirebaseManager
    {
        public FirebaseManager()
        {
            config = new FirebaseConfig
            {
                AuthSecret = "",
                BasePath = ""
            };
            client = new FirebaseClient(config);
        }
        private IFirebaseConfig config;
        private IFirebaseClient client;
        public IFirebaseClient db()
        {
            return client;
        }
    }

}