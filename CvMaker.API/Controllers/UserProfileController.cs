using CvMaker.Common;
using CvMaker.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace CvMaker.API.Controllers {
    [ApiController]
    public class UserProfileController : ControllerBase {
        private readonly IRepository<UserProfileModel> _userProfileRepository;

    }
}
