using Microsoft.AspNetCore.Mvc;
using RelatedActivitiesAPI.Models;

namespace RelatedActivitiesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelatedActivitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(
            string recordType,
            string recordId,
            string startDateTime = null,
            string endDateTime = null,
            int? top = null,
            int? skip = null,
            string creType = null,
            string crmorg = null)
        {
            var response = new RelatedActivities
            {
                Value = new List<Contract>
            {
                new Contract
                {
                    Title = "Contract signed",
                    Description = "You have 5 connections in Microsoft Inc",
                    DateTime = DateTime.Parse("2024-05-07T03:28:38.0667701Z"),
                    Url = null,
                    AdditionalProperties = new Dictionary<string, string>
                    {
                        { "Contract name", "Microsoft Renewal Contract" },
                        { "Signed by", "Singh, Amreek" },
                        { "Signed", "6/7/24" }
                    }
                },
                new Contract
                {
                    Title = "Contract signed",
                    Description = "Multiple stakeholders from Microsoft have visited the Copilot Lab website four times in the last four months",
                    DateTime = DateTime.Parse("2024-05-07T03:28:38.0669445Z"),
                    Url = null,
                    AdditionalProperties = new Dictionary<string, string>
                    {
                        { "Contract name", "Microsoft Automatic Renewal Contract" },
                        { "Signed by", "James, Toby" },
                        { "Signed", "6/7/24" }
                    }
                }
            },
                HasMoreResults = false
            };

            return Ok(response);
        }
    }
}
