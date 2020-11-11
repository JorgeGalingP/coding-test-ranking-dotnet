using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coding_test_ranking.infrastructure.api;
using Microsoft.AspNetCore.Mvc;

namespace coding_test_ranking.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class AdsController : ControllerBase
    {
        [HttpGet("qualityListing")]
        public ActionResult<IEnumerable<QualityAd>> qualityListing()
        {
            List<QualityAd> qualityAds = new List<QualityAd>();
            QualityAd quality = new QualityAd();
            quality.Id = 1;
            quality.Typology = "A";
            quality.Description = "Lorem Ipsum";

            qualityAds.Add(quality);

            if (qualityAds == null)
            {
                return NotFound();
            }

            return qualityAds;
        }

        [HttpGet("publicListing")]
        public ActionResult<IEnumerable<PublicAd>> publicListing()
        {
            return NotFound();
        }

        [HttpGet("calculateScore")]

        public ActionResult calculateScore()
        {
            return NotFound();
        }
    }
}
