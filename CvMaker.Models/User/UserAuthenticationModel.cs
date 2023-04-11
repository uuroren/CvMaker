using CvMaker.Common;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvMaker.Models.User {
    public class UserAuthenticationModel:IEntity {
        [BsonId]
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
