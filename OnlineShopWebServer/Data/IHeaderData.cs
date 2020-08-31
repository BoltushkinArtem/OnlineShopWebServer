using OnlineShopWebServer.Models;

namespace OnlineShopWebServer.Data
{
    public interface IHeaderData
    {
        Header GetActiveHeader();
        HeaderBanner GetBannerById(int id);

        string GetFileDirectoryPath();
    }
}