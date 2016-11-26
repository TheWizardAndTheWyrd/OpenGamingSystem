using AuthenticationApi.Models;
using OpenGamingSystem.Entities.Authentication;
using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace AuthenticationApi.Controllers
{
    [Authorize]
    public class ChangeEmailController : ApiController
    {
        private static readonly AuthenticationContext _db = new AuthenticationContext();

        [HttpGet]
        [ResponseType(typeof(List<ChangeEmailModel>))]
        public IHttpActionResult GetAllChangedEmails()
        {
            try
            {
                return Ok(_db.ChangeEmailModels.ToList());
            }
            catch (Exception e)
            {
                ServiceEventSource.Current.ServiceRequestFailed($"{e.TargetSite}", e.ToString());
                return InternalServerError(e);
            }
        }


        public async Task<IHttpActionResult> CreateChangedEmail([FromBody] ChangeEmailModel model)
        {
            try
            {
                
            }
            catch (Exception e)
            {

            }
        }

        bool DoesChangedEmailExist(ChangeEmailModel model)
        {
            if (_db.ChangeEmailModels.Find(model.Email) != null)
                return true;

            return false;
        }
    }
}
