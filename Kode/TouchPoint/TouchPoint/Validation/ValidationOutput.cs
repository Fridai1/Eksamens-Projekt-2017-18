using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Validation {
    public class ValidationOutput {
        public string Message {
            get;
        }

        public ValidationOutput(string message) {
            Message = message;
        }
    }
}
