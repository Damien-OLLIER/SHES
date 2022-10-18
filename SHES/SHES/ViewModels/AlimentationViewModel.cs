using SHES.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static SHES.Views.Alimentation;

namespace SHES.ViewModels
{
    public class AlimentationViewModel : BaseViewModel
    {
        public ObservableCollection<Model> models { get; set; }

        public AlimentationViewModel()
        {
            Title = "Alimentation";
            CreateCollection();
        }

        public void CreateCollection()
        {
            models = new ObservableCollection<Model>()
            {
                new Model()
                {
                    Name = "Synonym1",
                    Color = "A",
                    Icon = "soupeLentillesOrientale.png",
                    IsExpanded = false,
                    familyMember = new ObservableCollection<FamilyMember>
                    {
                        new FamilyMember
                        {
                            BirthDate = "Exemple de conseil nutrionnel",
                            Picture = "DogPicture.jpg",
                            NegatifPoint = "test",
                            PositifPoint = "S'énerve seulement quand elle a faim",
                            Description = "250 g de lentilles vertes" + Environment.NewLine + "300 g d’épinards frais " + Environment.NewLine + "1 citron" + Environment.NewLine + "1 oignon "
                                    + Environment.NewLine + "2 cuil. à soupe d’huile d’olive" + Environment.NewLine + "1/2 cuil. à café de cumin en poudre" + Environment.NewLine + "1 tablette de bouillon de volaille "
                                    + Environment.NewLine + "sel poivre" + Environment.NewLine
                        }
                    }
                }
            };
        }
    }
}

