using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartHome.Services
{
    class NavigationService
    {
        public Task PushAsync(Page page) => GetCurrentNavigation().PushAsync(page);
        INavigation GetCurrentNavigation() => (Application.Current as App).MainPage.Navigation;
    }
}
