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
    public partial class Alimentation : ContentPage
    {
        public Alimentation()
        {
            InitializeComponent();
        }

        public ObservableCollection<Family> MyFamily { get => GetFamilyInfo(); }

        // GetFamilyInfo() retourne une collection d'objet de la classe Family utilsé dans l'onglet family afin d'afficher l'expander (family  Tree)
        private ObservableCollection<Family> GetFamilyInfo()
        {
            return new ObservableCollection<Family>
            {
                new Family { Name = "Poulet curry", Color = "#B96CBD", Icon = "GirlIcon.PNG", IsExpanded = false, familyMember = new ObservableCollection<FamilyMember>{ new FamilyMember { BirthDate = "Exemple de conseil nutrionnel", Picture = "DogPicture.jpg", NegatifPoint = "Exemple de recette", PositifPoint = "S'énerve seulement quand elle a faim", Description = "Exemple de rectte" } } },

                new Family { Name = "Viande rouge", Color = "#49A24D", Icon = "DogPicture.PNG", IsExpanded = false, familyMember = new ObservableCollection<FamilyMember>{ new FamilyMember { BirthDate = "Exemple de conseil nutrionnel", Picture = "DogPicture.jpg", NegatifPoint = "Exemple de recette", PositifPoint = "Loulou très calin", Description = "Exemple de rectte" } } },

                new Family { Name = "Crepes", Color = "#FDA838", Icon = "RabbitIcon.PNG", IsExpanded = false, familyMember = new ObservableCollection<FamilyMember>{ new FamilyMember { BirthDate = "Exemple de conseil nutrionnel", Picture = "DogPicture.jpg", NegatifPoint = "Exemple de recette", PositifPoint = "Très doux et adore les caresses", Description = "Exemple de rectte" } } },

                new Family { Name = "gauffres",  Color = "#F75355",  Icon = "DogIcon.PNG", IsExpanded = false, familyMember = new ObservableCollection<FamilyMember>{ new FamilyMember { BirthDate = "Exemple de conseil nutrionnel", Picture = "DogPicture.jpg", NegatifPoint = "Exemple de recette", PositifPoint = "Il peut sauver des vies en mer", Description = "Exemple de rectte" } } },

                new Family { Name = "Crumble aux pommes",  Color = "#00C6AE", Icon = "CatIcon.PNG", IsExpanded = false, familyMember = new ObservableCollection<FamilyMember>{ new FamilyMember { BirthDate = "Exemple de conseil nutrionnel", Picture = "DogPicture.jpg", NegatifPoint = "Exemple de recette", PositifPoint = "Son ronronnement vous réconfortera", Description = "Exemple de rectte" } } },

            };
        }
        public class FamilyMember //Anciennement Speaker
        {
            //
            public string BirthDate { get; set; }
            public string Picture { get; set; }
            public string Description { get; set; }
            public string PositifPoint { get; set; }
            public string NegatifPoint { get; set; }
        }


        //Class Family qui permet de peupler le second onglet family
        public class Family
        {
            public string Name { get; set; } // nom tel que Damien, Camille, etc...
            public bool IsExpanded { get; set; } // est ce que l'expander est déplié au depart
            public ObservableCollection<FamilyMember> familyMember { get; set; }
            public string Color { get; set; } // couleur du trait de la box de gauche
            public string Icon { get; set; } // icon du family NuMber
        }

        //Modification de l'ouverture de l'expander afin de le rendre plus joli
        private async Task OpenAnimation(View view, uint length = 500)
        {
            //c'est un copié collé d'internet
            view.RotationX = -90;
            view.IsVisible = true;
            view.Opacity = 0;
            _ = view.FadeTo(1, length);
            await view.RotateXTo(0, length);
        }

        //Modification de la fermeture de l'expander afin de le rendre plus joli
        private async Task CloseAnimation(View view, uint length = 500)
        {
            //c'est un copié collé d'internet
            _ = view.FadeTo(0, length);
            await view.RotateXTo(-90, length);
            view.IsVisible = false;
        }

        private async void Expander_Tapped(object sender, EventArgs e)
        {
            // On obtient les infos de l'expander lorsque l'event est trigger 
            var expander = sender as Expander;

            //on essaie d'obtenir les infos sur le detailsview 
            var imageview = expander.FindByName<StackLayout>("imageview");
            var detailsview = expander.FindByName<StackLayout>("detailsview");

            //Ouverture ou fermeture suivant l'etat initial de l'expander
            if (expander.IsExpanded)
            {
                await OpenAnimation(detailsview);
            }
            else
            {
                await CloseAnimation(detailsview);
            }
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            this.BindingContext = this;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            PetitDejBtn.IsEnabled = false;
            DejBtn.IsEnabled = true;
            DinerBtn.IsEnabled = true;

            CollectionViewAliment.IsVisible = false;
            gif.IsVisible = true;
            await Task.Delay(1000);
            gif.IsVisible = false;

            CollectionViewAliment.IsVisible = true;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            PetitDejBtn.IsEnabled = true;
            DejBtn.IsEnabled = false;
            DinerBtn.IsEnabled = true;

            CollectionViewAliment.IsVisible = false;
            gif.IsVisible = true;
            await Task.Delay(1000);
            gif.IsVisible = false;
            CollectionViewAliment.IsVisible = true;
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            PetitDejBtn.IsEnabled = true;
            DejBtn.IsEnabled = true;
            DinerBtn.IsEnabled = false;

            CollectionViewAliment.IsVisible = false;
            gif.IsVisible = true;
            await Task.Delay(1000);
            gif.IsVisible = false;

            CollectionViewAliment.IsVisible = true;

        }
    }
}