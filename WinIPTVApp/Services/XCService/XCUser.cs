using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinIPTVApp.Services.XCService
{
    public class XCUser
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool auth { get; set; }
        public string status { get; set; }
        public string exp_date { get; set; }
        public string is_trial { get; set; }
        public string active_cons { get; set; }
        public string created_at { get; set; }
        public string max_connections { get; set; }
        public string[] allowed_output_formats { get; set; }
        public string token { get; set; }

        public XCUser() { }

        public XCUser(string _username, string _password, bool _auth, string _status, string _exp_date, string _is_trial, string _active_cons, string _created_at, string _max_connections)
        {
            username = _username;
            password = _password;
            auth = _auth;
            status = _status;
            exp_date = _exp_date;
            is_trial = _is_trial;
            active_cons = _active_cons;
            created_at = _created_at;
            max_connections = _max_connections;
        }
    }
}
