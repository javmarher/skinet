using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }

        public string Messaje { get; set; }

        public ApiResponse(int statusCode, string messaje = null)
        {
            StatusCode = statusCode;
            Messaje = messaje ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401 => "Autorized, you are not",
                404 => "Resource found, it was not",
                500 => "Errors are the path to the dark side. Errors lead to anger. Anger leads to career change",
                _ => null
            };
        }

       
    }
}
