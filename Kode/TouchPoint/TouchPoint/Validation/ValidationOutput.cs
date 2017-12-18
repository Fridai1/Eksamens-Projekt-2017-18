using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Validation {
    public class ValidationOutput {
        private string _message;

        public string Message {
            get { return _message; }
        }

        public ValidationOutput(string message) {
            _message = message;
        }
    }
}
