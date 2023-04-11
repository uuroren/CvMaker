using CvMaker.Common;
using CvMaker.Models.Enums;
using CvMaker.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvMaker.Models.User {
    public class UserProfileModel : IEntity {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public List<DriveringLicanceEnum?>? DrivingLicance { get; set; }
        public List<Education?>? Education { get; set; }
        public SoldieringStatusEnum SolderingStatus { get; set; }
        public List<string?>? Skills { get; set; }
        public List<string?>? Languages { get; set; }
        public List<string?>? Certifications { get; set; }
        public List<string?>? Experiences { get; set; }
        public TemplateModeEnum TemplateMode { get; set; }
    }
}
