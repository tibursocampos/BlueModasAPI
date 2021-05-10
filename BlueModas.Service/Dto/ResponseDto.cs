namespace BlueModas.Service.Dto
{ 
    public class ResponseDto
    {
        public bool Success { get; set; }

        public string ErrorMessage { get; set; }

        public ResponseDto Created()
        {
            Success = true;
            return this;
        }

        public ResponseDto Executed()
        {
            Success = true;
            return this;
        }
       
        public ResponseDto BadRequest(string validationMessage)
        {
            Success = false;
            ErrorMessage = validationMessage;
            return this;
        }

        public ResponseDto NotFound(string validationMessage)
        {
            Success = false;
            ErrorMessage = validationMessage;
            return this;
        }
    }
}
