using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvMaker.Common.Settings {
    public class MongoDbSettings {
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public string DatabaseName { get; set; }
        public string ConnectionString => $"mongodb://{Username}:{Password}@{Host}:{Port}/?authMechanism=SCRAM-SHA-256&authSource={DatabaseName}";
    }
}
