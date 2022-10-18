using SHES.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SHES.Models
{
    public class Model : INotifyPropertyChanged
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        #region fields
        public string _name;
        public string _Color;
        public string _Icon;
        public bool _isexpand;
        internal ObservableCollection<Alimentation.FamilyMember> familyMember;

        #endregion

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        public string Color
        {
            get { return _Color; }
            set { _Color = value; OnPropertyChanged("Color"); }
        }

        public bool IsExpanded
        {
            get { return _isexpand; }
            set { _isexpand = value; OnPropertyChanged("IsExpanded"); }
        }

        public string Icon
        {
            get { return _Icon; }
            set { _Icon = value; OnPropertyChanged("Icon"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}