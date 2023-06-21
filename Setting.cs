using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BaiTapLon_GameBox
{
    class Setting
    {
        public static int Width { get; set; }

        public static int Height { get; set; }

        public static string directions;

        public Setting() 
        {
            Width = 13;
            Height = 13;
            directions = "left";
        }
    }
}
