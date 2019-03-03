using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using Wrappers;
using InputValidation;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FunctionalityArgumentsValidator functionalityArgumentsValidator = new FunctionalityArgumentsValidator();
            Validation consoleInputValidation = new Validation(functionalityArgumentsValidator);
            FileDetails fileDetails = new FileDetails();
            ThirdPartyToolsWrapper thirdPartyToolsWrapper = new ThirdPartyToolsWrapper(fileDetails);

            if (consoleInputValidation.ValidInput(args))
            {
                if (functionalityArgumentsValidator.ValidSizeArgument(args[0]))
                    Console.WriteLine(thirdPartyToolsWrapper.Size(args[1]).ToString());
                else
                    Console.WriteLine(thirdPartyToolsWrapper.Version(args[1]).ToString());
            }
            else
            {
                Console.WriteLine("Invalid input argument(s).");
            }
            Console.ReadLine();
        }
    }
}
