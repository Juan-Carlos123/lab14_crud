using Xamarin.Forms;
using Lab13.DataContext;
using Lab13.Interfaces;
using Lab13.Views;


namespace Lab13
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GetContext().Database.EnsureCreated();
            MainPage = new NavigationPage(new Views.MainPage());
        }

        // Método para obtener el contexto cuando se inicia la aplicación
        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
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
