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

namespace Bajnding2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public Osoba o = new Osoba("Pera", "Peric");
		public MainWindow()
		{
			InitializeComponent();

			this.DataContext = o;
			this.BindingGroup = new BindingGroup();

			/*Binding bIme = new Binding();
			bIme.Source = o;
			bIme.Path = new PropertyPath("Ime");
			bIme.Mode = BindingMode.OneWay;

			BindingOperations.SetBinding(lIme, Label.ContentProperty, bIme);*/
		}

		private void Unos(object sender, RoutedEventArgs e)
		{
			//BindingOperations.GetBindingExpression(txtIme, TextBox.TextProperty)
			//	.UpdateSource();

			/*this.BindingGroup.ValidateWithoutUpdate(); //Mozda zatreba :) 

			if (this.BindingGroup.CommitEdit())
			{
				//Uspesno
			} else
			{
				//Neuspesno
			}*/

			Editor drugiProzor = new Editor();
			drugiProzor.Owner = this;
			drugiProzor.DataContext = this.DataContext;
			drugiProzor.ShowDialog(); //stojimo ovde dokle god se
									//drugi prozor ne zatvori

		}
	}
}
