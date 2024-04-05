using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public static class Helper
    {
        public static bool CheckBlogTitle(string title)
        {
            bool check = false;

            if (title.Length > 5)
            {
                check = true;
                return check;
            }

            else
            {
                return check;
            }
        }

        public static bool CheckBlogDescription(string description) 
        {
            bool check = false;

            if (description.Length > 8)
            {
                check = true;
                return check;
            }

            else
            {
                return check;
            }
        }
    }
}
