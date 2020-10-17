using System;
using System.Diagnostics;

namespace Xamarin.Forms.Controls.XamlPerformanceTests
{
	public class ContentPagePerformanceProvider : ContentPage
	{
		private readonly PerformanceProvider _performanceProvider;

		public ContentPagePerformanceProvider()
		{
			_performanceProvider = new PerformanceProvider();
			Internals.Performance.SetProvider(_performanceProvider);
		}

		public bool IsRunningPerformanceTimer { get; set; }

		public int PerformanceCounter { get; private set; }

		public void SetAutoLog(TimeSpan timeToLog, int timesToLog = 0, Action executeWithLog = null)
		{
			IsRunningPerformanceTimer = true;

			Device.StartTimer(timeToLog, () =>
			{
				LogPerformanceStatus();
				executeWithLog?.Invoke();

				return timesToLog <= 0 
					? IsRunningPerformanceTimer 
					: timesToLog > PerformanceCounter && IsRunningPerformanceTimer;
			});
		}

		public void LogPerformanceStatus()
		{
			PerformanceCounter++;
			Debug.WriteLine($"====== {PerformanceCounter} ======");
			_performanceProvider.DumpStats();
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			IsRunningPerformanceTimer = false;
		}
	}
}
