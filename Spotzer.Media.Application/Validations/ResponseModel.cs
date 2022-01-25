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
            IsValid = true;
            Messages = new List<string>();
        }
        public bool IsValid { get; set; }
        public List<string> Messages { get; set; }
    }
}
