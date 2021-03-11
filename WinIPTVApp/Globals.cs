using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinIPTVApp
{
    public class Globals
    {
        private static Globals _Instance;

        public static Globals Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new Globals();
                }
                return _Instance;
            }
        }

        private Globals() { }

        public static int selected_menu_index { get; set; } = -1;
        public static int selected_sub_menu_index { get; set; } = -1;

    }
}
