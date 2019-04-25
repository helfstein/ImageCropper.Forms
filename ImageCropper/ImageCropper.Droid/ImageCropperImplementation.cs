using System;
using Android.App;
using Android.Content;
using Com.Theartofdev.Edmodo.Cropper;
using Plugin.CurrentActivity;

namespace ImageCropper.Droid {
    public class ImageCropperImplementation : IImageCropperWrapper {
        public void ShowFromFile(ImageCropper imageCropper, string imageFile) {
            try {
                var activityBuilder = CropImage.Activity(Android.Net.Uri.FromFile(new Java.IO.File(imageFile)));
                var shape = imageCropper.CropShape == ImageCropper.CropShapeType.Oval
                    ? CropImageView.CropShape.Oval
                    : CropImageView.CropShape.Rectangle;
                activityBuilder.SetCropShape(shape);

                if (imageCropper.AspectRatioX > 0 && imageCropper.AspectRatioY > 0) {
                    activityBuilder.SetFixAspectRatio(true);
                    activityBuilder.SetAspectRatio(imageCropper.AspectRatioX, imageCropper.AspectRatioY);
                }
                else {
                    activityBuilder.SetFixAspectRatio(false);
                }

                if (!string.IsNullOrWhiteSpace(imageCropper.PageTitle)) {
                    activityBuilder.SetActivityTitle(imageCropper.PageTitle);
                }
                
                activityBuilder.Start(CrossCurrentActivity.Current.Activity);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}