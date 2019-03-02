using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InputValidation
{
    public class Validation
    {
        private List<string> _listOfValidFunctionalityCodes = new List<string>() { "–v", "--v", "/v", "--version", "–s", "--s", "/s", "--size" };
        private FunctionalityArgumentsValidator _functionalityArguments;

        public Validation(FunctionalityArgumentsValidator functionalityArguments)
        {
            _functionalityArguments = functionalityArguments;
        }

        public bool ValidInput(string[] consoleInput)
        {
            return consoleInput.Length == 2
                 && MemberOfExpectedSetOfInputs(consoleInput[0])
                 && FilePathIsValid(consoleInput[1]);
        }

        private bool FilePathIsValid(string v)
        {
            Match match = Regex.Match(v, @"^(?:[\w]\:|\/)(\/[a-z_\-\s0-9\.]+)+\.(txt|gif|pdf|doc|docx|xls|xlsx)$",
            RegexOptions.IgnoreCase);

            return match.Success;
        }

        private bool MemberOfExpectedSetOfInputs(string v)
        {
            return _functionalityArguments.ValidSizeArgument(v) ||
                _functionalityArguments.ValidVersionArgument(v);
        }
    }

}
