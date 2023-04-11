using CvMaker.Common;
using CvMaker.Models.Enums;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvMaker.Models.General {
    public class Education : IEntity {
        [BsonId]
        public Guid Id { get; set; }
        public string EducationName { get; set; }
        public EducationStatus EducationStatus { get; set; }
        public DateTime GraduationDate { get; set; }
    }
}
