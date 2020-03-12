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
using System.Windows.Shapes;

namespace Bajnding2
{
	/// <summary>
	/// Interaction logic for Editor.xaml
	/// </summary>
	public partial class Editor : Window
	{
		public Editor()
		{
			InitializeComponent();
			this.BindingGroup = new BindingGroup();
		}

		private void Unos(object sender, RoutedEventArgs e)
		{
			if (this.BindingGroup.CommitEdit())
			{
				this.Close();
			}
		}

		private void Izlaz(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
