using System.Text;

namespace RookEcomShop.CustomerFrontend.Services.Helpers
{
    public class QueryHelper
    {
        public static string ToQueryString<T>(T queryDto)
        {
            var properties = queryDto!.GetType().GetProperties();
            var queryString = new StringBuilder();
            foreach (var property in properties)
            {
                var value = property.GetValue(queryDto);
                if (value != null)
                {
                    queryString.Append($"{property.Name}={value}&");
                }
            }

            return queryString.ToString().TrimEnd('&');
        }
    }
}