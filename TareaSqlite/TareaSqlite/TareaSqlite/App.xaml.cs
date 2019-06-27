﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TareaSqlite.View;
using TareaSqlite.ViewModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TareaSqlite
{
    public partial class App : Application
    {
        public App(string filename)
        {
            InitializeComponent();
            VentasViewModel.Inicializador(filename);
            this.MainPage = new NavigationPage(new VentasView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

