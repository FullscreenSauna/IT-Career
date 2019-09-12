using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sites_and_Numbers
{
    public class Smartphone : ICall, IBrowse
    {
        public string[] PhoneNumbers { get; private set; }
        public string[] Websites { get; private set; }

        public Smartphone(string[] phoneNumbers, string[] websites)
        {
            PhoneNumbers = phoneNumbers;
            Websites = websites;
        }

        public string Browse()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var currentSite in Websites)
            {
                if (ValidateSite(currentSite))
                {
                    sb.AppendLine($"Browsing: {currentSite}");
                }
                else
                {
                    sb.AppendLine($"Invalid Site!");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string Call()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var currentNumber in PhoneNumbers)
            {
                if (ValidateNumber(currentNumber))
                {
                    sb.AppendLine($"Calling... {currentNumber}");
                }
                else
                {
                    sb.AppendLine($"Invalid Number!");
                }
            }

            return sb.ToString().TrimEnd();
        }

        private bool ValidateSite(string currentSite)
        {
            if (currentSite.Any(char.IsNumber))
            {
                return false;
            }
            return true;
        }

    

        private bool ValidateNumber(string currentNumber)
        {
            if (currentNumber.Any(char.IsLetter))
            {
                return false;
            }
            return true;
        }

 
    }
}
