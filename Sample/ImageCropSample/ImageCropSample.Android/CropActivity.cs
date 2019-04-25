using Android.App;
using Android.OS;

namespace ImageCropSample.Droid {
    [Activity(Label = "Crop")]
    public class CropActivity : Activity {
        protected override void OnCreate(Bundle bundle) {

           
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Crop);
            // Create your application here
        }
    }
}