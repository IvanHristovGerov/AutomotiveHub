using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Constants
{
    public static class MessageConstants
    {
        public const string RequireMessage = "The field is required";

        public const string Error = "There is an Error!";
        public const string Success = "Successful";
        public const string LengthMessage = "The field {0} must be between {2} and {1} characters";

        public const string DealerMessage = "You are already a dealer!";

        public const string DealerPhoneExists = "This phone number is already added!";

        public const string YearOfProductionMessage = "The field must be a positive number between.";

        public const string PricePerDayMessage = "The field  must be a positive number between.";

        public const string CategoryNotExists = "This Category does not exist.";

        public const string CouldNotCreateCar = "Something's wrong! Please try again.";

        public const string SuccessfulCreation = "You have successfully added new car";
    }
}
