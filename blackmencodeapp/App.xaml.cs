﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace blackmencodeapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BlkMenCodeLandingPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
