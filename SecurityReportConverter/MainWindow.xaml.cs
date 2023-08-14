using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Serilog;

namespace SecurityReportConverter
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			txtFolder.Text = Settings.Default.Directory;
		}

		private void btnSelectFolder_OnClick(object sender, RoutedEventArgs e)
		{
			var dialog = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog();
			if (dialog.ShowDialog(this).GetValueOrDefault())
			{
				txtFolder.Text = dialog.SelectedPath;
				Settings.Default.Directory = txtFolder.Text;
				Settings.Default.Save();
			}
		}

		private void btnSave_OnClick(object sender, RoutedEventArgs e)
		{
			/*if (_searchResult == null || _searchResult.Result.Keys.Count == 0)
			{
				return;
			}*/

			var dialog = new Ookii.Dialogs.Wpf.VistaSaveFileDialog()
			{
				Filter = "xlsx|*.xlsx",
				DefaultExt = "xlsx"
			};
			if (!dialog.ShowDialog(this).GetValueOrDefault())
			{
				return;
			}

			if (string.IsNullOrEmpty(dialog.FileName))
			{
				return;
			}

			// var saveService = new SaveService();

			try
			{
				// saveService.Save(dialog.FileName, _searchResult);
			}
			catch (Exception exception)
			{
				Log.Error(exception, "Ошибка записи файла.");
				MessageBox.Show("Ошибка записи файла");
			}

			MessageBox.Show($"Файл '{dialog.FileName}' успешно сохранён.");

		}
	}
}
