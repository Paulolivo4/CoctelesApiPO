namespace CoctelesApiPO
{
    public partial class MainPage : ContentPage
    {
        private readonly CocktailServicePO _cocktailService;

        public MainPage()
        {
            InitializeComponent();
            _cocktailService = new CocktailServicePO();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var cocktails = await _cocktailService.ObtenerCocktails("margarita");

            // Mostrar los resultados en la UI, por ejemplo en una lista
            cocktailListView.ItemsSource = cocktails;
        }
    }

}
