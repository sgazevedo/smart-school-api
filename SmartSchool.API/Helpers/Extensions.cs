using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;

namespace SmartSchool.API.Helpers
{
    public static class Extensions
    {
        public static void AddPagination(this HttpResponse response, 
            int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);

            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

            response.Headers.Append("Pagination", JsonConvert.SerializeObject(
                paginationHeader, camelCaseFormatter));
            response.Headers.Append("Access-Control-Expose-Header", "Pagination");
        }
    }
}