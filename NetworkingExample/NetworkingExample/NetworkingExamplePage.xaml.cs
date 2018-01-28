using Xamarin.Forms;

namespace NetworkingExample
{
    public partial class NetworkingExamplePage : ContentPage
    {
        public NetworkingExamplePage()
        {
            InitializeComponent();


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MoviesDAO.GetMovies((movies) =>
                {

                    foreach (MovieModel movie in movies)
                    {
                        
                    this.lbJson.Text = this.lbJson.Text + "\n" + movie;

                        System.Diagnostics.Debug.WriteLine(movie);

                    }

                },
                () =>
            {
                DisplayAlert("Error", "Ocurrió un error al consumir el servicio Web", "Ok");
            }
            );
        }
    }
}
