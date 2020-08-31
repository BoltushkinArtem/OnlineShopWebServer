using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShopWebServer.Data;
using OnlineShopWebServer.Models;

namespace OnlineShopWebServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeaderController : ControllerBase
    {
        private readonly MockHeaderData data = new MockHeaderData();

        [HttpGet("active/")]
        public ActionResult<IEnumerable<Header>> GetActiveHeader()
        {
            return Ok(new Response<Header>
            {
                data = this.data.GetActiveHeader(),
                messages = new string[] { "" },
                responseCode = 0
            });
        }

        [HttpGet("image/{id}")]
        public async Task<ActionResult> GetImage(int id)
        {
            HeaderBanner banner = data.GetBannerById(id);

            string filePath = $@"{data.GetFileDirectoryPath()}{banner.Title}";
            var memoty = new MemoryStream();
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                await stream.CopyToAsync(memoty);
            }
            memoty.Position = 0;
            var ext = Path.GetExtension(filePath).ToLowerInvariant();
            return File(memoty, @"image/png", Path.GetFileName(filePath));
        }
    }
}