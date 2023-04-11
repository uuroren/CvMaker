using CvMaker.API.Template;
using CvMaker.Common;
using CvMaker.Models.User;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace CvMaker.API.Controllers {
    [ApiController]
    public class UserAuthenticationController : ControllerBase {

        private readonly IRepository<UserAuthenticationModel> _userRepository;
        public UserAuthenticationController(IRepository<UserAuthenticationModel> user) {
            _userRepository = user;
        }

        [HttpPost("/user/register-user")]
        public async Task<IActionResult> CreateUserProfile([FromBody] UserAuthenticationModel user) {
            if (user == null) {
                return BadRequest();
            }
            await _userRepository.CreateAsync(user);
            return Ok(user);
        }
        [HttpPost("/user/createcv")]
        public async Task<IActionResult> CreateCv([FromBody] UserProfileModel model) {
            if (model == null) {
                return BadRequest();
            }

            var cv = CvTemplateGenerator.BasicTemplate(model);

            var pdf = PdfConvert(cv, model.Name + " " + model.Surname);


            return Ok(pdf);
        }

        public static byte[] PdfConvert(string html, string name) {
            var renderer = new ChromePdfRenderer() {
                RenderingOptions = {
                    CreatePdfFormsFromHtml= true,
                    EnableJavaScript = true,
                    CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print,

                }
            };
            var pdf = renderer.RenderHtmlAsPdf(html);
            //pdf.SaveAs($"{name}.pdf");
            return pdf.BinaryData;
        }
    }
}
