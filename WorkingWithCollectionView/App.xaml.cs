using WorkingWithCollectionView.MVVM.Views;

namespace WorkingWithCollectionView
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new LayoutsPage();
		}
	}
}
