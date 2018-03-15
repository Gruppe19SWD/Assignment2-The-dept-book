using System.ComponentModel;
using System.Runtime.CompilerServices;
using OverviewWindow.Properties;

namespace OverviewWindow.ViewModel
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
