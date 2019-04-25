using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageCropSample {
    public class MainViewModel : BaseViewModel {

        private ImageSource _imageSource;

        public Command TakePhotoCommand { get; set; }

        public ImageSource ImageSource {
            get => _imageSource;
            set {
                if (_imageSource != value) {
                    _imageSource = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainViewModel() {
            TakePhotoCommand = new Command(async () => {
                try {
                    if (IsBusy) return;
                    IsBusy = true;
                    new ImageCropper.ImageCropper {
                        AspectRatioX = 1,
                        AspectRatioY = 1,
                        Success = imageFile => {
                            Device.BeginInvokeOnMainThread(() => {
                                ImageSource = ImageSource.FromFile(imageFile);
                                IsBusy = false;
                            });
                        },
                        Failure = () => {
                            Console.WriteLine("Falha");
                            Device.BeginInvokeOnMainThread(() => { IsBusy = false; });
                        }
                    }.Show(Application.Current.MainPage);
                    await Task.Delay(1);
                }
                catch (Exception e) {
                    Console.WriteLine(e);
                    IsBusy = false;
                }
                
            });
        }

    }
}