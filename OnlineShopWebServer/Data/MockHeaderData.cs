using Microsoft.AspNetCore.Hosting;
using OnlineShopWebServer.Models;

namespace OnlineShopWebServer.Data
{
    public class MockHeaderData : IHeaderData
    {
        public Header GetActiveHeader()
        {
            return new Header
            {
                Id = 0,
                Banner = new HeaderBanner
                {
                    Id = 0,
                    Title = "test-one.jpg",
                    BackgroundColor = "#4db4e0"
                }
            };
        }

        public HeaderBanner GetBannerById(int id)
        {
            return GetActiveHeader().Banner;
        }

        public string GetFileDirectoryPath()
        {
            return $@"./Data/Files/";
        }
    }
}