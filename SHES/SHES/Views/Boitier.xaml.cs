﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SHES.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Boitier : ContentPage
    {
        public Boitier()
        {
            InitializeComponent();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            this.BindingContext = this;
        }

        private void Switch_Toggled_1(object sender, ToggledEventArgs e)
        {
            if (SwitchName.Text == "Connecté")
            {
                SwitchName.Text = "Offline";
                Switch1.ThumbColor = Color.Red;
            }
            else if (SwitchName.Text == "Offline")
            {
                SwitchName.Text = "Connecté";
                Switch1.ThumbColor = Color.Green;
            }
        }
    }
}