using System;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls.XamlPerformanceTests.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MelhorLayoutDepois : ContentPagePerformanceProvider
	{
		public MelhorLayoutDepois()
		{
			InitializeComponent();
			SetAutoLog(TimeSpan.FromSeconds(1), 1);
		}
	}
}
