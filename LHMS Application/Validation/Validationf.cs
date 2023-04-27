using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LHMS_Application.Validation
{
    internal class Validationf
    {
        public bool TextOnly(string textOnly)
        {
            Regex check = new Regex(@"^[a-zA-Z\s]+$");
            bool valid = false;
            valid = check.IsMatch(textOnly);

            if (valid)
                return valid;
            else
                return valid;
        }

        public bool NumbersOnly(string numOnly)
        {
            Regex check = new Regex(@"^[0-9]+$");
            bool valid = false;
            valid = check.IsMatch(numOnly);

            if (valid)
                return valid;
            else
                return valid;
        }

        public bool CurrencyValues(string numOnly)
        {
            Regex check = new Regex(@"^[0-9\.\,]+$");
            bool valid = false;
            valid = check.IsMatch(numOnly);

            if (valid)
                return valid;
            else
                return valid;
        }

        public bool TextnNumbersOnly(string TextNumOnly)
        {
            Regex check = new Regex(@"^[a-zA-Z0-9\s]+$");
            bool valid = false;
            valid = check.IsMatch(TextNumOnly);

            if (valid)
                return valid;
            else
                return valid;
        }

        //public bool TextnNumbersAllowEmpty(string TextNumOnly)
        //{
        //    Regex check = new Regex(@"$|^[a-zA-Z0-9\s]+$");
        //    bool valid = false;
        //    valid = check.IsMatch(TextNumOnly);

        //    if (valid)
        //        return valid;
        //    else
        //        return valid;
        //}

        public bool UsernameValidate(string TextNumOnly)
        {
            Regex check = new Regex(@"^[a-zA-Z0-9]+$");
            bool valid = false;
            valid = check.IsMatch(TextNumOnly);

            if (valid)
                return valid;
            else
                return valid;
        }

        public bool EmailValidate(string emailOnly)
        {
            Regex check = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
            bool valid = false;
            valid = check.IsMatch(emailOnly);

            if (valid)
                return valid;
            else
                return valid;
        }

        public bool NumbersSeparators(string NumSOnly)
        {
            Regex check = new Regex(@"^[0-9\.\-\/]+$");
            bool valid = false;
            valid = check.IsMatch(NumSOnly);

            if (valid)
                return valid;
            else
                return valid;
        }

        public bool TextnNumbersSeparators(string TextNumSOnly)
        {
            Regex check = new Regex(@"^[a-zA-Z0-9\.\-\/]+$");
            bool valid = false;
            valid = check.IsMatch(TextNumSOnly);

            if (valid)
                return valid;
            else
                return valid;
        }

        public bool TextnNumbersSeparatorsMin(string TextNumSOnly)
        {
            Regex check = new Regex(@"^[a-zA-Z0-9\-\s]+$");
            bool valid = false;
            valid = check.IsMatch(TextNumSOnly);

            if (valid)
                return valid;
            else
                return valid;
        }

        public bool AddressValidate(string TextNumSOnly)
        {
            Regex check = new Regex(@"^[a-zA-Z0-9\.\,\-\/\s\r\n]+$");
            bool valid = false;
            valid = check.IsMatch(TextNumSOnly);

            if (valid)
                return valid;
            else
                return valid;
        }
    }
}
