using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Serilog;

namespace SecurityReportConverter
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public App()
		{
			Current.DispatcherUnhandledException += App_UnhandledException;

			Log.Logger = new LoggerConfiguration()
				.MinimumLevel.Debug()
				.WriteTo.File("logs\\application.log", rollingInterval: RollingInterval.Day)
				.CreateLogger();
		}

		void App_UnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
		{
			Log.Error(e.Exception, "Непредвиденная ошибка.");
		}
	}
}
