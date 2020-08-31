namespace OnlineShopWebServer.Models
{
    public class Response<T>
    {
        public T data { get; set; }
        public string[] messages { get; set; }
        public byte responseCode { get; set; }
    }
}