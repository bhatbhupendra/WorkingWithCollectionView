using WorkingWithCollectionView.MVVM.ViewModels;

namespace WorkingWithCollectionView.MVVM.Views;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();
		BindingContext = new DataViewModels();
	}
}