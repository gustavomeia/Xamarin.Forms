using System;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls.XamlPerformanceTests.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MelhorLayoutAntes : ContentPagePerformanceProvider
	{
		public MelhorLayoutAntes()
		{
			InitializeComponent();
			SetAutoLog(TimeSpan.FromSeconds(1), 1);
		}
	}
}
