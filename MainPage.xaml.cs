using test.ViewModel;

namespace test
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            
        }

        
    }

}
