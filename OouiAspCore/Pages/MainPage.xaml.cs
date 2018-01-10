using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OouiAspCore.Pages
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var button = sender as Button;

            if (button == null)
                return;

            count++;
            button.Text = $"Você clicou {count} vezes!";
        }

    }
}
