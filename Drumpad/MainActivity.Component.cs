
using Android.Support.V7.App;
using Android.Widget;

namespace Drumpad {
    /// <summary>
    ///  partial class for initialize the component
    /// </summary>
    public partial class MainActivity : AppCompatActivity {
#nullable enable

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // private Methods [verb, verb phrases]

        /// <summary>
        /// initialize the component.
        /// </summary>
        void initializeComponent() {
            var _buttonBassDrum = FindViewById<Button>(Resource.Id.button_bass_drum);
            _buttonBassDrum.Touch += buttonBassDrum_Touch;
            var _buttonSnareDrum = FindViewById<Button>(Resource.Id.button_snare_drum);
            _buttonSnareDrum.Touch += buttonSnareDrum_Touch;
            var _buttonHiHatOpen = FindViewById<Button>(Resource.Id.button_hi_hat_open);
            _buttonHiHatOpen.Touch += buttonHiHatOpen_Touch;
            var _buttonHiHatClose = FindViewById<Button>(Resource.Id.button_hi_hat_close);
            _buttonHiHatClose.Touch += buttonHiHatClose_Touch;

            var _buttonLowTomDrum = FindViewById<Button>(Resource.Id.button_low_tom_drum);
            _buttonLowTomDrum.Touch += buttonLowTomDrum_Touch;
            var _buttonMidTomDrum = FindViewById<Button>(Resource.Id.button_mid_tom_drum);
            _buttonMidTomDrum.Touch += buttonMidTomDrum_Touch;
            var _buttonHiTomDrum = FindViewById<Button>(Resource.Id.button_hi_tom_drum);
            _buttonHiTomDrum.Touch += buttonHiTomDrum_Touch;
            var _buttonCrashCymbal = FindViewById<Button>(Resource.Id.button_crash_cymbal);
            _buttonCrashCymbal.Touch += buttonCrashCymbal_Touch;

            var _buttonLowConga = FindViewById<Button>(Resource.Id.button_low_conga);
            _buttonLowConga.Touch += buttonLowConga_Touch;
            var _buttonMuteHiConga = FindViewById<Button>(Resource.Id.button_mute_hi_conga);
            _buttonMuteHiConga.Touch += buttonMuteHiConga_Touch;
            var _buttonOpenHiConga = FindViewById<Button>(Resource.Id.button_open_hi_conga);
            _buttonOpenHiConga.Touch += buttonOpenHiConga_Touch;
            var _buttonClaves = FindViewById<Button>(Resource.Id.button_claves);
            _buttonClaves.Touch += buttonClaves_Touch;

            var _buttonTambourine = FindViewById<Button>(Resource.Id.button_tambourine);
            _buttonTambourine.Touch += buttonTambourine_Touch;
            var _buttonRimShot = FindViewById<Button>(Resource.Id.button_rim_shot);
            _buttonRimShot.Touch += buttonRimShot_Touch;
            var _buttonHandClap = FindViewById<Button>(Resource.Id.button_hand_clap);
            _buttonHandClap.Touch += buttonHandClap_Touch;
            var _buttonCowBell = FindViewById<Button>(Resource.Id.button_cow_bell);
            _buttonCowBell.Touch += buttonCowBell_Touch;

            var _buttonHiTimbale = FindViewById<Button>(Resource.Id.button_hi_timbale);
            _buttonHiTimbale.Touch += buttonHiTimbale_Touch;
            var _buttonLowTimbale = FindViewById<Button>(Resource.Id.button_low_timbale);
            _buttonLowTimbale.Touch += buttonLowTimbale_Touch;
            var _buttonHiAgogo = FindViewById<Button>(Resource.Id.button_hi_agogo);
            _buttonHiAgogo.Touch += buttonHiAgogo_Touch;
            var _buttonLowAgogo = FindViewById<Button>(Resource.Id.button_low_agogo);
            _buttonLowAgogo.Touch += buttonLowAgogo_Touch;

            var _buttonCabasa = FindViewById<Button>(Resource.Id.button_cabasa);
            _buttonCabasa.Touch += buttonCabasa_Touch;
            var _buttonMaracas = FindViewById<Button>(Resource.Id.button_maracas);
            _buttonMaracas.Touch += buttonMaracas_Touch;
            var _buttonHiWoodBlock = FindViewById<Button>(Resource.Id.button_hi_wood_block);
            _buttonHiWoodBlock.Touch += buttonHiWoodBlock_Touch;
            var _buttonLowWoodBlock = FindViewById<Button>(Resource.Id.button_low_wood_block);
            _buttonLowWoodBlock.Touch += buttonLowWoodBlock_Touch;
        }
    }
}
