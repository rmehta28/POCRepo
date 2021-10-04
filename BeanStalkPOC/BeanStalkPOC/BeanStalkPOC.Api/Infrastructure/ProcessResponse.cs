using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BeanStalkPOC.Api.Infrastructure
{
    /// <summary>
    /// Method contains apiresponse properties and method to created desired response.
    /// </summary>
    public static class ProcessResponse
    {
        #region '---- Methods ----'

        /// <summary>
        /// Method to create common response for API.
        /// </summary>
        /// <param name="result">result object</param>
        /// <param name="message">message string</param>
        /// <param name="statusCode">status code</param>
        /// <returns>ObjectResult</returns>
        public static ObjectResult Create(object result, string message, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            ObjectResult response = new ObjectResult(new { Message = message, StatusCode = statusCode, Data = result });

            return response;
        }

        #endregion
    }
}
