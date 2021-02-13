using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using System;
using System.Threading;
using Xamarin.Essentials;
using fluid_settings_t_ptr = System.IntPtr;
using fluid_synth_t_ptr = System.IntPtr;
using fluid_audio_driver_t_ptr = System.IntPtr;

using NativeFuncs;

namespace Drumpad {

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity {

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // Fields

        const string soundFontPath = "/storage/emulated/0/Music/SoundFont/GeneralUser GS v1.47.sf2";

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // public Methods [verb]

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults) {
            Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // protected Methods [verb]

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            helloFluidsynth();
            Log.Info(":)");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // private Methods [verb]

        void helloFluidsynth() {
            fluid_settings_t_ptr _setting = IntPtr.Zero;
            fluid_synth_t_ptr _synth = IntPtr.Zero;
            fluid_audio_driver_t_ptr _adriver = IntPtr.Zero;
            try {
                _setting = Fluidsynth.new_fluid_settings();
                _synth = Fluidsynth.new_fluid_synth(_setting);
                _adriver = Fluidsynth.new_fluid_audio_driver(_setting, _synth);
                int _sfont_id = Fluidsynth.fluid_synth_sfload(_synth, soundFontPath, true);
                if (_sfont_id == -1) {
                    return; // TODO:
                }
                /* Do useful things here */
                for (int _i = 0; _i < 12; _i++) {
                    int _key = 60 + _i; // Generate a key
                    Fluidsynth.fluid_synth_noteon(_synth, 0, _key, 120); // Play a note
                    Thread.Sleep(500); // Sleep for 0.5 second
                    Fluidsynth.fluid_synth_noteoff(_synth, 0, _key); // Stop the note
                }
            } catch (Exception ex) {
                // TODO:
            } finally {
                Fluidsynth.delete_fluid_audio_driver(_adriver);
                Fluidsynth.delete_fluid_synth(_synth);
                Fluidsynth.delete_fluid_settings(_setting);
            }
        }
    }
}