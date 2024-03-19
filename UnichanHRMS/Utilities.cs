using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnichanHRMS
{
    public  class Utilities
    {
        public  Color defaultThemePrimaryColor = Color.FromArgb(255, 152, 0);
        public  Color defaultThemeBackgroundColor = Color.FromArgb(255, 255, 255, 255);
        public Utilities() {
            defaultThemePrimaryColor = Color.FromArgb(255, 152, 0);
            defaultThemeBackgroundColor = Color.FromArgb(255, 255, 255, 255);
        }
    }
}
