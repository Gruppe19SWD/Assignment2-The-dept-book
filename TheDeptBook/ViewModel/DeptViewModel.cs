using System.ComponentModel;
using System.Runtime.CompilerServices;
using TheDeptBook.Properties;

namespace TheDeptBook.ViewModel
{
    class DeptViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
