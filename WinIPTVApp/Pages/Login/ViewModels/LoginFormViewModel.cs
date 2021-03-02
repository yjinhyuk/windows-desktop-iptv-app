using Caliburn.Micro;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinIPTVApp.Dialogs.AlertDialog;
using WinIPTVApp.Dialogs.References;
using WinIPTVApp.Services.XCService;

namespace WinIPTVApp.Pages.Login.ViewModels
{
    public class LoginFormViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public string Username { get; set; } = "Username";
        public string Password { get; set; } = "Password";

        private IDialogService dialogService;

        public LoginFormViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            dialogService = new DialogService();
        }

        public void Login()
        {
            if(Username.Equals("Username") || Password.Equals("Password"))
            {
                var warningDlg = new AlertDialogViewModel("WARNING", "YOU SHOULD INPUT USERNAME AND PASSWORD");
                dialogService.OpenDialog(warningDlg);
            } else
            {
                XCAPI xcapi = new XCAPI();
                string authResult = xcapi.Authenticate(Username, Password);

                if (authResult.Equals("Error"))
                {
                    var warningDlg = new AlertDialogViewModel("WARNING", "APP OR SERVICE IS NOT WORKING WITH PROVIDER SERVICE, PLEASE CONTACT WITH PROVIDER");
                    dialogService.OpenDialog(warningDlg);
                } else if (authResult.Equals("Bad_Streaming_URL"))
                {
                    var warning_dialog = new AlertDialogViewModel("Warning", "STREAMING URL OR YOUR IP IS NOT ALLOWED TO GET STREAMING, PLEASE USE VPN");
                    var result = dialogService.OpenDialog(warning_dialog);
                } else {
                    JObject authUser = JObject.Parse(authResult);
                    if ((int)authUser["user_info"]["auth"] == 0)
                    {
                        var warning_dialog = new AlertDialogViewModel("Warning", "INCORRECT USER NAME AND PASSWORD. PLEASE INPUT CORRECT ONE");
                        var result = dialogService.OpenDialog(warning_dialog);
                    }
                    else if ((int)long.Parse((string)authUser["user_info"]["active_cons"]) + 1 > (int)long.Parse((string)authUser["user_info"]["max_connections"]))
                    {
                        var warning_dialog = new AlertDialogViewModel("Warning", "YOU HAVE LIMITED CONNECTIONS, PLEASE EXTEND CONNECTION BY UPGRADING MEMBERSHIP");
                        var result = dialogService.OpenDialog(warning_dialog);
                    }
                    else if ((DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / 1000) > (int)Int64.Parse((string)authUser["user_info"]["exp_date"]) || (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / 1000) < (int)Int64.Parse((string)authUser["user_info"]["created_at"]))
                    {
                        var warning_dialog = new AlertDialogViewModel("Warning", "YOUR ACCOUNT IS EXPIRED ALREADY, PLEASE CONTACT TO PROVIDER");
                        var result = dialogService.OpenDialog(warning_dialog);
                    }
                    else if (!((string)authUser["user_info"]["status"]).Equals("Active"))
                    {
                        var warning_dialog = new AlertDialogViewModel("Warning", "YOUR ACCOUNT IS NOT ACTIVATED. PLEASE MAKE YOUR ACCOUNT ACTIVATE");
                        var result = dialogService.OpenDialog(warning_dialog);
                    }
                    else if (!((string)authUser["user_info"]["is_trial"]).Equals("0"))
                    {
                        var warning_dialog = new AlertDialogViewModel("Warning", "YOUR ACCOUNT IS NOT TRIAL NOW. PLEASE PURCHASE APP NOW");
                        var result = dialogService.OpenDialog(warning_dialog);
                    }
                    else
                    {
                        XCUser xcUser = new XCUser();
                        xcUser.username = (string)authUser["user_info"]["username"];
                        xcUser.password = (string)authUser["user_info"]["password"];
                        xcUser.auth = (int)authUser["user_info"]["auth"] > 0 ? true : false;
                        xcUser.status = (string)authUser["user_info"]["status"];
                        xcUser.exp_date = (string)authUser["user_info"]["exp_date"];
                        xcUser.is_trial = (string)authUser["user_info"]["is_trial"];
                        xcUser.active_cons = (string)authUser["user_info"]["active_cons"];
                        xcUser.created_at = (string)authUser["user_info"]["created_at"];
                        xcUser.max_connections = (string)authUser["user_info"]["max_connections"];
                        xcUser.allowed_output_formats = authUser["user_info"]["allowed_output_formats"].ToObject<string[]>();

                        // Global.currentUser = xcUser;

                        // _eventAggregator.PublishOnUIThread(new SuccessAuthenticatedMessage());
                    }
                }
                return;
            }
        }
    }
}
