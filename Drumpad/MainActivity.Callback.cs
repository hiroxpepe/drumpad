
using Android.Support.V7.App;
using Android.Views;
using static Android.Views.View;

namespace Drumpad {
    /// <summary>
    ///  partial class for event callback functions.
    /// </summary>
    public partial class MainActivity : AppCompatActivity {
#nullable enable

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // Const [nouns]

        const int BASS_DRUM_NOTE = 36;
        const int SNARE_DRUM_NOTE = 38;
        const int HI_HAT_OPEN_NOTE = 46;
        const int HI_HAT_CLOSE_NOTE = 42;
        
        const int LOW_TOM_DRUM_NOTE = 45;
        const int MID_TOM_DRUM_NOTE = 47;
        const int HI_TOM_DRUM_NOTE = 50;
        const int CRASH_CYMBAL_NOTE = 49;

        const int LOW_CONGA_NOTE = 64;
        const int MUTE_HI_CONGA_NOTE = 62;
        const int OPEN_HI_CONGA_NOTE = 63;
        const int CLAVES_NOTE = 75;

        const int TAMBOURINE_NOTE = 54;
        const int RIM_SHOT_NOTE = 37;
        const int HAND_CLAP_NOTE= 39;
        const int COW_BELL_NOTE = 56;

        const int HI_TIMBALE_NOTE = 65;
        const int LOW_TIMBALE_NOTE = 66;
        const int HI_AGOGO_NOTE = 67;
        const int LOW_AGOGO_NOTE = 68;

        const int CABASA_NOTE = 69;
        const int MARACAS_NOTE = 70;
        const int HI_WOOD_BLOCK_NOTE = 76;
        const int LOW_WOOD_BLOCK_NOTE = 77;

        ///////////////////////////////////////////////////////////////////////////////////////////////
        // private Methods [verb]

        /// <summary>
        /// buttonBassDrum Touch.
        /// </summary>
        void buttonBassDrum_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(BASS_DRUM_NOTE);
            }
        }
        /// <summary>
        /// buttonSnareDrum Touch.
        /// </summary>
        void buttonSnareDrum_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(SNARE_DRUM_NOTE);
            }
        }
        /// <summary>
        /// buttonHiHatOpen Touch.
        /// </summary>
        void buttonHiHatOpen_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(HI_HAT_OPEN_NOTE);
            }
        }
        /// <summary>
        /// buttonHiHatClose Touch.
        /// </summary>
        void buttonHiHatClose_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(HI_HAT_CLOSE_NOTE);
            }
        }

        /// <summary>
        /// buttonLowTomDrum Touch.
        /// </summary>
        void buttonLowTomDrum_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(LOW_TOM_DRUM_NOTE);
            }
        }
        /// <summary>
        /// buttonMidTomDrum Touch.
        /// </summary>
        void buttonMidTomDrum_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(MID_TOM_DRUM_NOTE);
            }
        }
        /// <summary>
        /// buttonHiTomDrum Touch.
        /// </summary>
        void buttonHiTomDrum_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(HI_TOM_DRUM_NOTE);
            }
        }
        /// <summary>
        /// buttonCrashCymbal Touch.
        /// </summary>
        void buttonCrashCymbal_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(CRASH_CYMBAL_NOTE);
            }
        }

        /// <summary>
        /// buttonLowConga Touch.
        /// </summary>
        void buttonLowConga_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(LOW_CONGA_NOTE);
            }
        }
        /// <summary>
        /// buttonMidConga Touch.
        /// </summary>
        void buttonMuteHiConga_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(MUTE_HI_CONGA_NOTE);
            }
        }
        /// <summary>
        /// buttonHiConga Touch.
        /// </summary>
        void buttonOpenHiConga_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(OPEN_HI_CONGA_NOTE);
            }
        }
        /// <summary>
        /// buttonClaves Touch.
        /// </summary>
        void buttonClaves_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(CLAVES_NOTE);
            }
        }

        /// <summary>
        /// buttonTambourine Touch.
        /// </summary>
        void buttonTambourine_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(TAMBOURINE_NOTE);
            }
        }
        /// <summary>
        /// buttonRimShot Touch.
        /// </summary>
        void buttonRimShot_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(RIM_SHOT_NOTE);
            }
        }
        /// <summary>
        /// buttonHandClap Touch.
        /// </summary>
        void buttonHandClap_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(HAND_CLAP_NOTE);
            }
        }
        /// <summary>
        /// buttonCrashCymbal Touch.
        /// </summary>
        void buttonCowBell_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(COW_BELL_NOTE);
            }
        }

        /// <summary>
        /// buttonHiTimbale Touch.
        /// </summary>
        void buttonHiTimbale_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(HI_TIMBALE_NOTE);
            }
        }
        /// <summary>
        /// buttonLowTimbale Touch.
        /// </summary>
        void buttonLowTimbale_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(LOW_TIMBALE_NOTE);
            }
        }
        /// <summary>
        /// buttonHiAgogo Touch.
        /// </summary>
        void buttonHiAgogo_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(HI_AGOGO_NOTE);
            }
        }
        /// <summary>
        /// buttonLowAgogo Touch.
        /// </summary>
        void buttonLowAgogo_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(LOW_AGOGO_NOTE);
            }
        }

        /// <summary>
        /// buttonCabasa Touch.
        /// </summary>
        void buttonCabasa_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(CABASA_NOTE);
            }
        }
        /// <summary>
        /// buttonMaracas Touch.
        /// </summary>
        void buttonMaracas_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(MARACAS_NOTE);
            }
        }
        /// <summary>
        /// buttonHiWoodBlock Touch.
        /// </summary>
        void buttonHiWoodBlock_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(HI_WOOD_BLOCK_NOTE);
            }
        }
        /// <summary>
        /// buttonLowWoodBlock Touch.
        /// </summary>
        void buttonLowWoodBlock_Touch(object sender, TouchEventArgs? e) {
            if (e?.Event?.ActionMasked == MotionEventActions.Down) {
                playDrumNote(LOW_WOOD_BLOCK_NOTE);
            }
        }
    }
}
