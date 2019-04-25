using Xamarin.Forms;

namespace ImageCropper.iOS {
    public class Platform {
        public static void Init() {
            DependencyService.Register<IImageCropperWrapper, ImageCropperImplementation>();
        }
    }
}