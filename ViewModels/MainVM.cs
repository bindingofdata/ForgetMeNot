using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ForgetMeNot.ViewModels
{
    [ObservableObject]
    public partial class MainVM
    {
        [ObservableProperty]
        private bool imageIsVisible = true;

        [ObservableProperty]
		private string _fullName;
        [ObservableProperty]
        private string _selectedImage = "ministry_of_information.jpg";

        [RelayCommand]
        private void ToggleImageVisibility()
        {
            ImageIsVisible = !ImageIsVisible;
        }

        [RelayCommand]
        private void ImageTapped()
        {
            ImageIsVisible = !ImageIsVisible;
        }
    }
}
