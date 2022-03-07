
using Android;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.Content;
using Android.Support.V7.App;
using Android.Runtime;

using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

using static NativeFuncs.Fluidsynth;
using fluid_settings_t = System.IntPtr;
using fluid_synth_t = System.IntPtr;
using fluid_audio_driver_t = System.IntPtr;

namespace Drumpad {

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public partial class MainActivity : AppCompatActivity {
#nullable enable

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // Const [nouns]

        /// <summary>
        /// need the following sound font file in that directory.
        /// </summary>
        const string SOUND_FONT_PATH = "/storage/emulated/0/Music/SoundFont/OmegaGMGS2.sf2";

        const int MIDI_CHANNEL = 9;
        const int NOTE_VELOCITY = 120;

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // static Fields [nouns, noun phrases]

        static fluid_settings_t _setting = IntPtr.Zero;

        static fluid_synth_t _synth = IntPtr.Zero;

        static fluid_audio_driver_t _adriver = IntPtr.Zero;

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // EventHandler

        /// <summary>
        /// Activity OnRequestPermissionsResult.
        /// </summary>
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults) {
            Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        /// <summary>
        /// Activity OnCreate.
        /// </summary>
        protected override void OnCreate(Bundle? savedInstanceState) {
            base.OnCreate(savedInstanceState);
            try {
                requestPermissions();
                Platform.Init(this, savedInstanceState);
                // Set our view from the "main" layout resource
                SetContentView(Resource.Layout.activity_main);

                initializeComponent();
                initializeFluidsynth();
                Log.Info("complete onCreated.");
            } catch (Exception ex) {
                Log.Error(ex.Message);
            }
        }

        /// <summary>
        /// Activity OnDestroy.
        /// </summary>
        protected override void OnDestroy() {
            try {
                terminateFluidsynth();
            } catch (Exception ex) {
                Log.Error(ex.Message);
            } finally {
                base.OnDestroy();
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // private Methods [verb]

        /// <summary>
        /// request permissions.
        /// </summary>
        void requestPermissions() {
            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.ReadExternalStorage) != (int) Permission.Granted) {
                ActivityCompat.RequestPermissions(this, new string[] { Manifest.Permission.ReadExternalStorage }, 0);
            }
            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.WriteExternalStorage) != (int) Permission.Granted) {
                ActivityCompat.RequestPermissions(this, new string[] { Manifest.Permission.WriteExternalStorage }, 0);
            }
        }

        /// <summary>
        /// initialize Fluidsynth.
        /// </summary>
        void initializeFluidsynth() {
            try {
                _setting = new_fluid_settings();
                _synth = new_fluid_synth(_setting);
                _adriver = new_fluid_audio_driver(_setting, _synth);
                Log.Info($"try to load the sound font: {SOUND_FONT_PATH}");
                if (fluid_is_soundfont(SOUND_FONT_PATH) != 1) {
                    Log.Error("not a sound font.");
                    return;
                }
                int sfont_id = fluid_synth_sfload(_synth, SOUND_FONT_PATH, true);
                if (sfont_id == FLUID_FAILED) {
                    Log.Error("failed to load the sound font.");
                    return;
                } else {
                    Log.Info($"loaded the sound font: {SOUND_FONT_PATH}");
                }
                Log.Info("initialized Fluidsynth.");
            } catch (Exception ex) {
                Log.Error(ex.Message);
            }
        }

        /// <summary>
        /// terminate Fluidsynth.
        /// </summary>
        void terminateFluidsynth() {
            try {
                delete_fluid_audio_driver(_adriver);
                delete_fluid_synth(_synth);
                delete_fluid_settings(_setting);
                Log.Info("terminated Fluidsynth.");
            } catch (Exception ex) {
                Log.Error(ex.Message);
            }
        }

        /// <summary>
        /// play a drum note.
        /// </summary>
        void playDrumNote(int noteNumber) {
            try {
                Task.Run(() => {
                    fluid_synth_noteon(_synth, MIDI_CHANNEL, noteNumber, NOTE_VELOCITY); // play a note.
                    // MIDI drum channel is usually not recognized for note off.
                });
            } catch (Exception ex) {
                Log.Error(ex.Message);
            }
        }
    }
}
