namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? getDefaultMessageForStatusCode(statusCode);;
        }
        public int StatusCode { get; set; }
        public string Message {get;set;}

        private string getDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request",
                401 => "Not authorized",
                404 => "Resource not found",
                500 => "Server Error",
                _ => null
            };
        }
    }
 
}