namespace Libraries.Responses
{
    public class ApiResponse
    {
        public bool Success { get; set; }               // Indicates whether the request was successful
        public string Message { get; set; }             // A message describing the result of the operation
        public object Data { get; set; } = new List<string>();                  // Holds any type of object for data (generic)

        public ApiResponse() { }

        public ApiResponse(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }
}
