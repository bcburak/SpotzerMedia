using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Validations
{
    public class ResponseModel
    {
        public ResponseModel()
        {
            IsSuccess = true;
            Messages = new List<string>();
        }
        public bool IsSuccess { get; set; }
        public List<string> Messages { get; set; }
    }
}
