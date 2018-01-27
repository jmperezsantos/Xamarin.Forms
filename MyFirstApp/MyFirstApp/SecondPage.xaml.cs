using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class SecondPage : ContentPage
    {

        public string Message { get; set; }

        public SecondPage()
        {
            InitializeComponent();

            this.Title = "Bienvenido";

            this.btnBack.Clicked += (sender, e) => {

                this.Navigation.PopAsync(false);

            };

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            this.lbMessage.Text = this.Message;


        }
    }
}
