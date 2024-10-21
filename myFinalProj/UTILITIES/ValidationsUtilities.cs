using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace myFinalProj.UTILITIES
{
    class ValidationsUtilities
    {
        public static bool LegalId(string s)
        {
            int x;
            if (!int.TryParse(s, out x))
                return false;
            if (s.Length < 5 || s.Length > 9)
                return false;
            for (int i = s.Length; i < 9; i++)
                s = "0" + s;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                char c = s[i]; ;
                int k = ((i % 2) + 1) * (c - '0');
                if (k > 9)
                    k -= 9;
                sum += k;

            }
            return sum % 10 == 0;
        }
        public static bool PhoneNumber(string num)
        {
            string pattern = @"\b0[2-4 7-9]-[2-9]\d{6}";
            Regex r = new Regex(pattern);
            return r.IsMatch(num);
        }
        public static bool LegalName(string name)
        {
            string pattern = @"\b[א-ת- ]+";
            Regex r = new Regex(pattern);
            return r.IsMatch(name);
        }
        public static int GetAge(DateTime d)
        {
            DateTime t = DateTime.Today;
            int age = t.Year - d.Year;
            if (t < d.AddYears(age)) age--;
            return age;
        }



        public static bool GreaterThanZero(int num)
        {
            return num > 0;
        }

        public static bool IsHebrewLetter(char c)
        {
            string otiyot = "'אבגדהוזחטיכלמנסעפצקרשתךםןףץ";
            if (otiyot.IndexOf(c) == -1)
                return false;
            return true;
        }

        public static bool IsEnglishLetter(char c)
        {
            string otiyot = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'";
            if (otiyot.IndexOf(c) == -1)
                return false;
            return true;
        }

        public static bool IsDigits(char c)
        {
            string digits = "0123456789";
            if (digits.IndexOf(c) == -1)
                return false;
            return true;
        }

        public static bool IsLegalItemName(string word)
        {
            foreach (char c in word)
                if (IsDigits(c) == false && IsHebrewLetter(c) == false && c != '-' && c != ' ' && IsEnglishLetter(c) == false)
                    return false;
            return true;
        }

        public static bool IsLegalName(string word)
        {
            foreach (char c in word)
                if (IsHebrewLetter(c) == false && IsEnglishLetter(c) == false && c != '-')
                    return false;
            return true;
        }

        public static bool IsLegalCity(string word)
        {
            foreach (char c in word)
                if (IsHebrewLetter(c) == false && IsEnglishLetter(c) == false && c != '-' && c != ' ')
                    return false;
            return true;
        }

        public static bool IsLegalId(string id)
        {
            string word = id;
            if (word.Length != 9)
                return false;
            foreach (char c in word)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalDigit(string dig)
        {
            string digit = dig;
            foreach (char c in digit)
                if (digit.IndexOf(c) == -1)
                    return false;
            return true;
        }
        public static bool IsLegalZipcode(string zip)
        {
            string zipcode = zip;
            if (zipcode.Length != 5)
                return false;
            foreach (char c in zipcode)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalCNumberVisa(string cnum)
        {
            string creditnumber = cnum;
            if (creditnumber.Length != 16)
                return false;
            foreach (char c in creditnumber)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalCNumberAmericanexpress(string cnum)
        {
            string creditnumber = cnum;
            if (creditnumber.Length != 15)
                return false;
            foreach (char c in creditnumber)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalThreeDig(string tdig)
        {
            string threedig = tdig;
            if (threedig.Length != 3)
                return false;
            foreach (char c in threedig)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalItemId(string id)
        {
            string word = id;
            if (word.Length != 4)
                return false;
            foreach (char c in word)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static string SubPhon(string word)
        {
            string sub;
            if (word.Length == 11)
                sub = word.Substring(0, 3);
            else
                sub = word.Substring(0, 2);

            return sub;
        }
        public static string PhoneNum(string word)
        {
            string phone = "";
            if (word.Length == 11)
                phone = word.Substring(4);
            else
                phone = word.Substring(3);

            return phone;
        }
        public static bool IsPhoneNum(string word)
        {
            bool s = false;
            if (PhoneNum(word).Length == 7)
                s = true;
           return s;
        }
       
    }
}
