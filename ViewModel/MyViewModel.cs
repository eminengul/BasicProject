using stok.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok.ViewModel  
{
    internal class MyViewModel: INotifyPropertyChanged
    {

        private ObservableCollection<Option> options;
        private Option selectedOption;

        public MyViewModel()
        {
            // ComboBox'ta görüntülenecek seçenekleri burada tanımlayabilirsiniz.
            Options = new ObservableCollection<Option>
        {
            new Option { Id = 1, Name = "Arpa" },
            new Option { Id = 2, Name = "Yonca" },
            new Option { Id = 3, Name = "Mısır" },
            new Option { Id = 4, Name = "Buğday" },
            new Option { Id = 5, Name = "Fiğ" },
            new Option { Id = 6, Name = "Soya Fasulyesi" },
            new Option { Id = 7, Name = "Pamuk Tohumu" },
            new Option { Id = 8, Name = "Saman" },
            new Option { Id = 9, Name = "Kaba Yem" },
            new Option { Id = 10, Name = "Kuru Ot" },
            new Option { Id = 11, Name = "Fişek Ot" },
            new Option { Id = 12, Name = "Yulaf" },
            new Option { Id = 13, Name = "Üzüm Posası" },
            new Option { Id = 14, Name = "Patates" },
            new Option { Id = 15, Name = "Pirinç Kabuğu" },
            new Option { Id = 16, Name = "Kepek" },
            new Option { Id = 17, Name = "Yonca Küspesi" },
            new Option { Id = 18, Name = "Borungu Ot" }
        };
        }

        public ObservableCollection<Option> Options
        {
            get { return options; }
            set
            {
                options = value;
                OnPropertyChanged("Options");
            }
        }

        public Option SelectedOption
        {
            get { return selectedOption; }
            set
            {
                selectedOption = value;
                OnPropertyChanged("SelectedOption");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

  
}
