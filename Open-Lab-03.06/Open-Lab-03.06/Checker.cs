using System;

namespace Open_Lab_03._06
{
    public class Checker
    {
        public bool HasSpaces(string str)
        {
            bool space = str.Contains(" ");
            if (space)
            {
                return true; 
            }
            else
            { 
                return false;
            }

        }
    }
}
