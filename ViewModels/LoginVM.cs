using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNot.ViewModels
{
    public partial class LoginVM : ObservableObject
    {
        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _lostPasswordExcuse;

        [RelayCommand]
        private void Submit()
        {

        }
    }
}
