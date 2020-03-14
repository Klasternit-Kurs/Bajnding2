using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		public ObservableCollection<Osoba> Osobe = 
			new ObservableCollection<Osoba>();
		public MainWindow()
		{
			InitializeComponent();
			Osobe.Add(new Osoba("Pera", "Peric"));
			Osobe.Add(new Osoba("Neko", "Nekic"));
			Osobe.Add(new Osoba("Trecko", "Treckovic"));
			dg.ItemsSource = Osobe;
			
			this.BindingGroup = new BindingGroup();

			/*Binding bIme = new Binding();
			bIme.Source = o;
			bIme.Path = new PropertyPath("Ime");
			bIme.Mode = BindingMode.OneWay;

			BindingOperations.SetBinding(lIme, Label.ContentProperty, bIme);*/
		}

		private void Obrisi(object o, RoutedEventArgs a)
		{
			if (dg.SelectedItem != null)
			{
				Osobe.Remove(dg.SelectedItem as Osoba);
			}
		}

		private void Izmena(object zklj, RoutedEventArgs e)
		{
			if (dg.SelectedItem != null)
			{
				Editor Ed = new Editor();
				Ed.Owner = this;
				Ed.DataContext = dg.SelectedItem;
				Ed.ShowDialog();
			}
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
			//drugiProzor.ShowDialog(); //stojimo ovde dokle god se
									  //drugi prozor ne zatvori
			string asd = null;
			Osoba a = null;
			
			bool asdd = true;
			bool? dsa = null;
			
			if (drugiProzor.ShowDialog() == true)
			{
				Osobe.Add(drugiProzor.DataContext as Osoba);
			}
		}
	}
}
