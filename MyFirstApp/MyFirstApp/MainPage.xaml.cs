using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.eInput.Text = "Hola Mundo!";

            this.lbOutput.Text = "Etiqueta modificada desde código.";

            this.btnPress.Clicked += BtnPress_Clicked;
            //this.btnPress.Clicked += (sender, e) => {

            //    this.lbOutput.Text = this.eInput.Text;

            //    this.eInput.Text = string.Empty;

            //};

            this.Title = "Inicio";

            this.btnGo.Clicked += delegate {

                var second = new SecondPage();
                second.Message = this.eInput.Text;

                this.Navigation.PushAsync(second);

            };
        }

        void BtnPress_Clicked(object sender, EventArgs e)
        {

        }
    }
}
