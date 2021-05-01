using CheckBinding.Models;
using CheckBinding.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBinding.ViewModels
{
    public class CategoryViewModel : ViewModel
    {

        public CategoryViewModel()
        {
            var lst = Enumerable.Range(1, 10)
                .Select(i => new Category
                {
                    Id = i,
                    Name = $"Caterogy{i}"
                });
            Categories = new List<Category>(lst);
        }

        public List<Category> Categories
        {
            get { return _Caterories; }
            set
            {
                _Caterories = value;
                OnPropertyChanged(nameof(Categories));
            }
        }

        public Category SelectedCategoryComboBox
        {
            get { return _SelectedCategoryComboBox; }
            set
            {
                _SelectedCategoryComboBox = value;
                OnPropertyChanged(nameof(SelectedCategoryComboBox));
            }
        }

        public Category SelectedCategoryListBox
        {
            get { return _SelectedCategoryListBox; }
            set
            {
                _SelectedCategoryListBox = value;
                OnPropertyChanged(nameof(SelectedCategoryListBox));
            }
        }


        private List<Category> _Caterories;
        private Category _SelectedCategoryComboBox;
        private Category _SelectedCategoryListBox;

    }
}
