
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
            _buttonBassDrum.Click += buttonBassDrum_Click;
            var _buttonSnareDrum = FindViewById<Button>(Resource.Id.button_snare_drum);
            _buttonSnareDrum.Click += buttonSnareDrum_Click;
            var _buttonHiHatOpen = FindViewById<Button>(Resource.Id.button_hi_hat_open);
            _buttonHiHatOpen.Click += buttonHiHatOpen_Click;
            var _buttonHiHatClose = FindViewById<Button>(Resource.Id.button_hi_hat_close);
            _buttonHiHatClose.Click += buttonHiHatClose_Click;

            var _buttonLowTomDrum = FindViewById<Button>(Resource.Id.button_low_tom_drum);
            _buttonLowTomDrum.Click += buttonLowTomDrum_Click;
            var _buttonMidTomDrum = FindViewById<Button>(Resource.Id.button_mid_tom_drum);
            _buttonMidTomDrum.Click += buttonMidTomDrum_Click;
            var _buttonHiTomDrum = FindViewById<Button>(Resource.Id.button_hi_tom_drum);
            _buttonHiTomDrum.Click += buttonHiTomDrum_Click;
            var _buttonCrashCymbal = FindViewById<Button>(Resource.Id.button_crash_cymbal);
            _buttonCrashCymbal.Click += buttonCrashCymbal_Click;

            var _buttonLowConga = FindViewById<Button>(Resource.Id.button_low_conga);
            _buttonLowConga.Click += buttonLowConga_Click;
            var _buttonMuteHiConga = FindViewById<Button>(Resource.Id.button_mute_hi_conga);
            _buttonMuteHiConga.Click += buttonMuteHiConga_Click;
            var _buttonOpenHiConga = FindViewById<Button>(Resource.Id.button_open_hi_conga);
            _buttonOpenHiConga.Click += buttonOpenHiConga_Click;
            var _buttonClaves = FindViewById<Button>(Resource.Id.button_claves);
            _buttonClaves.Click += buttonClaves_Click;

            var _buttonTambourine = FindViewById<Button>(Resource.Id.button_tambourine);
            _buttonTambourine.Click += buttonTambourine_Click;
            var _buttonRimShot = FindViewById<Button>(Resource.Id.button_rim_shot);
            _buttonRimShot.Click += buttonRimShot_Click;
            var _buttonHandClap = FindViewById<Button>(Resource.Id.button_hand_clap);
            _buttonHandClap.Click += buttonHandClap_Click;
            var _buttonCowBell = FindViewById<Button>(Resource.Id.button_cow_bell);
            _buttonCowBell.Click += buttonCowBell_Click;

            var _buttonHiTimbale = FindViewById<Button>(Resource.Id.button_hi_timbale);
            _buttonHiTimbale.Click += buttonHiTimbale_Click;
            var _buttonLowTimbale = FindViewById<Button>(Resource.Id.button_low_timbale);
            _buttonLowTimbale.Click += buttonLowTimbale_Click;
            var _buttonHiAgogo = FindViewById<Button>(Resource.Id.button_hi_agogo);
            _buttonHiAgogo.Click += buttonHiAgogo_Click;
            var _buttonLowAgogo = FindViewById<Button>(Resource.Id.button_low_agogo);
            _buttonLowAgogo.Click += buttonLowAgogo_Click;

            var _buttonCabasa = FindViewById<Button>(Resource.Id.button_cabasa);
            _buttonCabasa.Click += buttonCabasa_Click;
            var _buttonMaracas = FindViewById<Button>(Resource.Id.button_maracas);
            _buttonMaracas.Click += buttonMaracas_Click;
            var _buttonHiWoodBlock = FindViewById<Button>(Resource.Id.button_hi_wood_block);
            _buttonHiWoodBlock.Click += buttonHiWoodBlock_Click;
            var _buttonLowWoodBlock = FindViewById<Button>(Resource.Id.button_low_wood_block);
            _buttonLowWoodBlock.Click += buttonLowWoodBlock_Click;
        }
    }
}
