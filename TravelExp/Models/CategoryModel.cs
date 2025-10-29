﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace TravelExp.Models
{
    public partial class CategoryModel : ObservableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        [ObservableProperty]
        private bool _isSelected;
    }
}
