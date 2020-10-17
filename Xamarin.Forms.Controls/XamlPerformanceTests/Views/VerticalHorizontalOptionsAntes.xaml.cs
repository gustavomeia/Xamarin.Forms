using System;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls.XamlPerformanceTests.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VerticalHorizontalOptionsAntes : ContentPagePerformanceProvider
	{
		public VerticalHorizontalOptionsAntes()
		{
			InitializeComponent();
			SetAutoLog(TimeSpan.FromMilliseconds(100), 50, UpdateLabels);
		}

		private void UpdateLabels()
		{
			lbl1.Text = $"Update {PerformanceCounter}";
		}
	}
}
