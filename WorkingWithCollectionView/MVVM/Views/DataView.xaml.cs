using WorkingWithCollectionView.MVVM.ViewModels;

namespace WorkingWithCollectionView.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModels();
	}
}