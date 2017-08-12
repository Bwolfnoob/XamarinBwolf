using BwolfXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BwolfXamarin.ListTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProdutoTemplate : ContentView
    {
        public ProdutoTemplate()
        {
            InitializeComponent();
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var bind = (Produto)BindingContext;
            if (bind == null) return;

            if (bind.Novo)
            {
                Descricao.Text += " Novo****";
            }
        }
    }
}