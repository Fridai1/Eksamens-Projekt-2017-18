using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Validation {
    public class ValidationHandler {
        public static ValidationOutput Validate<TValue>(TValue value, Func<TValue, bool> isValid, string message) {
            return (isValid(value) ? null : new ValidationOutput(message)); //returns null if Func bool checks out, otherwise returns `message`
        }

        //gets called from domain-specific Validation classes
        public static void Throw<TValue>(Func<TValue, ValidationOutput> validator, TValue value) {
            ValidationOutput vo = validator(value);
            if(vo != null) {
                throw new ArgumentException(vo.Message);
            }
        }

        public static ValidationOutput ValidateExampleHelloWorldLength(string value, int length,    //string to validate, length that string must be.
        [CallerMemberName] string propertyName = null) {                                            //CallerMemberName takes name of member which called this method.
            string message = propertyName + " must contain " + " characters";                       //the error message sent to Validate.
            return Validate<string>(value, (v => v.Length == length), message);                     //returns message one line above if (v.Length != length),
                                                                                                    //otherwise null (see Validate)
        }
    }
}
