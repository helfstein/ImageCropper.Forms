using System.ComponentModel;
using System.Runtime.CompilerServices;
using ImageCropSample.Annotations;

namespace ImageCropSample {
    public class BaseViewModel : INotifyPropertyChanged {
        private bool _isBusy;

        public bool IsBusy {
            get => _isBusy;
            set {
                if (_isBusy != value) {
                    _isBusy = value;
                    OnPropertyChanged();
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}