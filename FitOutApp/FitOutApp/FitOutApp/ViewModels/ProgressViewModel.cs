﻿using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace FitOutApp.ViewModels
{
    public class ProgressViewModel : BaseViewModel
    {
        public ProgressViewModel()
        {
            Title = "Progress";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        /// <summary>
        /// Command to open browser to xamarin.com
        /// </summary>
        public ICommand OpenWebCommand { get; }
    }
}
