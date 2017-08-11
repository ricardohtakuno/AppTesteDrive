﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTestDrive.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalheView : ContentPage
	{
        public Veiculo Veiculo { get; set; }
		public DetalheView (Veiculo veiculo)
		{
            this.Veiculo = veiculo;
			InitializeComponent ();
            this.BindingContext = this;
		}
        private void botaoProximo_Clicked(object sender, EventArgs e)
        {

        }
	}
}