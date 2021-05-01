using CheckBinding.Models;
using CheckBinding.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBinding.ViewModels
{
    public class CategoryViewModel : ViewModel
    {

        private List<Category> _Caterories;
        public List<Category> Categories
        {
            get { return _Caterories; }
            set
            {
                _Caterories = value;
                OnPropertyChanged(nameof(Categories));
            }
        }

        public CategoryViewModel()
        {

        }

    }
}
