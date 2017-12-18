using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Validation.Domain.Bruger {
    class Validator<T> where T : ISaveable {
        public static ValidationOutput ValidationIsNull(T value) {
            return (ValidationHandler<T>.ValidateObjectNull(value));
        }
    }
}
