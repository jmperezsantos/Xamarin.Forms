
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ListViewExample
{
    public partial class ListViewExamplePage : ContentPage
    {


        public ListViewExamplePage()
        {
            InitializeComponent();


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var adapter = new ObservableCollection<SongModel>();

            adapter.Add(new SongModel("title 1", "subtitle 1", "duration 1"));
            adapter.Add(new SongModel("title 2", "subtitle 2", "duration 2"));
            adapter.Add(new SongModel("title 3", "subtitle 3", "duration 3"));
            adapter.Add(new SongModel("title 1", "subtitle 1", "duration 1"));
            adapter.Add(new SongModel("title 2", "subtitle 2", "duration 2"));
            adapter.Add(new SongModel("title 3", "subtitle 3", "duration 3"));
            adapter.Add(new SongModel("title 1", "subtitle 1", "duration 1"));
            adapter.Add(new SongModel("title 2", "subtitle 2", "duration 2"));
            adapter.Add(new SongModel("title 3", "subtitle 3", "duration 3"));
            adapter.Add(new SongModel("title 1", "subtitle 1", "duration 1"));
            adapter.Add(new SongModel("title 2", "subtitle 2", "duration 2"));
            adapter.Add(new SongModel("title 3", "subtitle 3", "duration 3"));
            adapter.Add(new SongModel("title 1", "subtitle 1", "duration 1"));
            adapter.Add(new SongModel("title 2", "subtitle 2", "duration 2"));
            adapter.Add(new SongModel("title 3", "subtitle 3", "duration 3"));
            adapter.Add(new SongModel("title 1", "subtitle 1", "duration 1"));
            adapter.Add(new SongModel("title 2", "subtitle 2", "duration 2"));
            adapter.Add(new SongModel("title 3", "subtitle 3", "duration 3"));
            adapter.Add(new SongModel("title 1", "subtitle 1", "duration 1"));
            adapter.Add(new SongModel("title 2", "subtitle 2", "duration 2"));
            adapter.Add(new SongModel("title 3", "subtitle 3", "duration 3"));

            this.lvLista.ItemsSource = adapter;

            this.lvLista.RowHeight = 75;

            this.lvLista.ItemTapped += (object sender, ItemTappedEventArgs e) =>{

                SongModel song = e.Item as SongModel;
                System.Diagnostics.Debug.WriteLine("Presionó: " + song.Title);

            };

        }

    }
}
