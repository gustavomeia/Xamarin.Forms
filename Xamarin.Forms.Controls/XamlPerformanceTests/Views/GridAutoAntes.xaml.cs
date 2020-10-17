using System;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls.XamlPerformanceTests.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridAutoAntes : ContentPagePerformanceProvider
	{
		public GridAutoAntes()
		{
			InitializeComponent();
			SetAutoLog(TimeSpan.FromMilliseconds(500), 10, UpdateLabels);
		}

		private void UpdateLabels()
		{
			lbl1.Text = $"Update {PerformanceCounter}";
			lbl2.Text = $"Update {PerformanceCounter}";
			lbl3.Text = $"Update {PerformanceCounter}";
		}
	}
}
