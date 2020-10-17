using System;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls.XamlPerformanceTests
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void MelhorLayoutAntes(object sender, EventArgs e)
			=> Application.Current.MainPage.Navigation.PushAsync(new Views.MelhorLayoutAntes());

		private void MelhorLayoutDepois(object sender, EventArgs e)
			=> Application.Current.MainPage.Navigation.PushAsync(new Views.MelhorLayoutDepois());

		private void GridAutoAntes(object sender, EventArgs e)
			=> Application.Current.MainPage.Navigation.PushAsync(new Views.GridAutoAntes());

		private void GridAutoDepois(object sender, EventArgs e)
			=> Application.Current.MainPage.Navigation.PushAsync(new Views.GridAutoDepois());

		private void VerticalHorizontalOptionsAntes(object sender, EventArgs e)
			=> Application.Current.MainPage.Navigation.PushAsync(new Views.VerticalHorizontalOptionsAntes());

		private void VerticalHorizontalOptionsDepois(object sender, EventArgs e)
			=> Application.Current.MainPage.Navigation.PushAsync(new Views.VerticalHorizontalOptionsDepois());

		private void ExpandsExemplos(object sender, EventArgs e)
			=> Application.Current.MainPage.Navigation.PushAsync(new Views.ExpandsExemplos());
	}
}
