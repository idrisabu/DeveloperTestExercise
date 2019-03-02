using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    public class FunctionalityArgumentsValidator
    {
        private List<string> _listOfValidSizeFunctionalityCodes = new List<string>() { "–s", "--s", "/s", "--size" };
        private List<string> _listOfValidVersionFunctionalityCodes = new List<string>() { "–v", "--v", "/v", "--version" };


        public bool ValidSizeArgument(string argument)
        {
            return _listOfValidSizeFunctionalityCodes.Contains(argument);
        }

        public bool ValidVersionArgument(string argument)
        {
            return _listOfValidVersionFunctionalityCodes.Contains(argument);
        }
    }
}
