using BwolfXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BwolfXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProdutosPage : ContentPage
	{
        private readonly ObservableCollection<Produto> Lista;

		public ProdutosPage ()
		{
			InitializeComponent ();

            ListViewProduto.ItemsSource = Lista = new ObservableCollection<Produto>();

        }


        protected override void OnAppearing()
        {
            base.OnAppearing();


            for (int i = 0; i < 10; i++)
            {
                Lista.Add(new Produto() { Id = i, Descricao = $"Produto {i}", Valor = 10*i  , Novo = i%2==0});
            }

        }
    }
}