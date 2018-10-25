using PersonalMentalHealthTracker.Api.Models;
using PersonalMentalHealthTracker.Domain;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace PersonalMentalHealthTracker.Api.Controllers
{
    [Route("api/v1/users")]
    public class UserController : ApiController
    {
        private MentalHealthContext _mentalHealthContext;

        public UserController()
        {
            _mentalHealthContext = new MentalHealthContext();
        }

        public async Task<ICollection<UserModel>> GetAllUsers()
        {
            var users = await _mentalHealthContext.Users.Select(x => new UserModel
            {
                UserId = x.UserId,
                Username = x.Username,
                Password = x.Password,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToListAsync();

            return users;
        }
    }
}
