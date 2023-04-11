using CvMaker.Models.User;
using System.Xml.Linq;

namespace CvMaker.API.Template {

    public class CvTemplateGenerator {
        public static string BasicTemplate(UserProfileModel user) {
            var html = System.IO.File.ReadAllText("Template/basic.html");
            html = html.Replace("{name}", user.Name + " " + user.Surname);
            return html;
        }

    }
}