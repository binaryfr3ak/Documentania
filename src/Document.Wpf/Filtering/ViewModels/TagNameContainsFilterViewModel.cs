﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="TagNameContainsFilterViewModel.cs" company="BaerDev">
// // Copyright (c) BaerDev. All rights reserved.
// // </copyright>
// // <summary>
// // The file 'TagNameContainsFilterViewModel.cs'.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
namespace Document.Wpf.Filtering.ViewModels
{
    using Document.Model;
    using Model.Filter;

    public class TagNameContainsFilterViewModel : FilterViewModelBase
    {
        private string filterText;

        public string FilterText
        {
            get { return this.filterText; }
            set
            {
                this.filterText = value;
                this.OnPropertyChanged();
            }
        }

        public override Filter CreateFilter(Filter filter)
        {
            this.Decorator = new TagNameContainsFilter(filter, this.filterText);
            return this.Decorator;
        }
    }
}