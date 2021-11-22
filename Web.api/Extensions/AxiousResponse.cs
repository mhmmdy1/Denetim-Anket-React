using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.api.Extensions
{
    public class AxiousResponse
    {
        public bool IsSucceeded { get; set; }
        public string ResultCode { get; set; }
        public List<AxiousErrorMessage> ErrorMessages { get; set; }
        public object Data { get; set; }
        public string ReturnData { get; set; }

        public AxiousResponse()
        {
            IsSucceeded = false;
            ErrorMessages = new List<AxiousErrorMessage>();
        }

        public void AddError(string message)
        {
            IsSucceeded = false;

            ErrorMessages.Add(new AxiousErrorMessage
            {
                ErrorMessage = message,
            });
        }

    }

    public class AxiousErrorMessage
    {
        public string ErrorMessage { get; set; }

        public AxiousErrorMessage New(string message)
        {
            return new AxiousErrorMessage
            {
                ErrorMessage = message,
            };
        }
    }
}
