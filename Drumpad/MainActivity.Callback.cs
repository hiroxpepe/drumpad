
using Android.Support.V7.App;

using System;

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
        /// buttonBassDrum Click.
        /// </summary>
        void buttonBassDrum_Click(object sender, EventArgs e) {
            playDrumNote(BASS_DRUM_NOTE);
        }
        /// <summary>
        /// buttonSnareDrum Click.
        /// </summary>
        void buttonSnareDrum_Click(object sender, EventArgs e) {
            playDrumNote(SNARE_DRUM_NOTE);
        }
        /// <summary>
        /// buttonHiHatOpen Click.
        /// </summary>
        void buttonHiHatOpen_Click(object sender, EventArgs e) {
            playDrumNote(HI_HAT_OPEN_NOTE);
        }
        /// <summary>
        /// buttonHiHatClose Click.
        /// </summary>
        void buttonHiHatClose_Click(object sender, EventArgs e) {
            playDrumNote(HI_HAT_CLOSE_NOTE);
        }

        /// <summary>
        /// buttonLowTomDrum Click.
        /// </summary>
        void buttonLowTomDrum_Click(object sender, EventArgs e) {
            playDrumNote(LOW_TOM_DRUM_NOTE);
        }
        /// <summary>
        /// buttonMidTomDrum Click.
        /// </summary>
        void buttonMidTomDrum_Click(object sender, EventArgs e) {
            playDrumNote(MID_TOM_DRUM_NOTE);
        }
        /// <summary>
        /// buttonHiTomDrum Click.
        /// </summary>
        void buttonHiTomDrum_Click(object sender, EventArgs e) {
            playDrumNote(HI_TOM_DRUM_NOTE);
        }
        /// <summary>
        /// buttonCrashCymbal Click.
        /// </summary>
        void buttonCrashCymbal_Click(object sender, EventArgs e) {
            playDrumNote(CRASH_CYMBAL_NOTE);
        }

        /// <summary>
        /// buttonLowConga Click.
        /// </summary>
        void buttonLowConga_Click(object sender, EventArgs e) {
            playDrumNote(LOW_CONGA_NOTE);
        }
        /// <summary>
        /// buttonMidConga Click.
        /// </summary>
        void buttonMuteHiConga_Click(object sender, EventArgs e) {
            playDrumNote(MUTE_HI_CONGA_NOTE);
        }
        /// <summary>
        /// buttonHiConga Click.
        /// </summary>
        void buttonOpenHiConga_Click(object sender, EventArgs e) {
            playDrumNote(OPEN_HI_CONGA_NOTE);
        }
        /// <summary>
        /// buttonClaves Click.
        /// </summary>
        void buttonClaves_Click(object sender, EventArgs e) {
            playDrumNote(CLAVES_NOTE);
        }

        /// <summary>
        /// buttonTambourine Click.
        /// </summary>
        void buttonTambourine_Click(object sender, EventArgs e) {
            playDrumNote(TAMBOURINE_NOTE);
        }
        /// <summary>
        /// buttonRimShot Click.
        /// </summary>
        void buttonRimShot_Click(object sender, EventArgs e) {
            playDrumNote(RIM_SHOT_NOTE);
        }
        /// <summary>
        /// buttonHandClap Click.
        /// </summary>
        void buttonHandClap_Click(object sender, EventArgs e) {
            playDrumNote(HAND_CLAP_NOTE);
        }
        /// <summary>
        /// buttonCrashCymbal Click.
        /// </summary>
        void buttonCowBell_Click(object sender, EventArgs e) {
            playDrumNote(COW_BELL_NOTE);
        }

        /// <summary>
        /// buttonHiTimbale Click.
        /// </summary>
        void buttonHiTimbale_Click(object sender, EventArgs e) {
            playDrumNote(HI_TIMBALE_NOTE);
        }
        /// <summary>
        /// buttonLowTimbale Click.
        /// </summary>
        void buttonLowTimbale_Click(object sender, EventArgs e) {
            playDrumNote(LOW_TIMBALE_NOTE);
        }
        /// <summary>
        /// buttonHiAgogo Click.
        /// </summary>
        void buttonHiAgogo_Click(object sender, EventArgs e) {
            playDrumNote(HI_AGOGO_NOTE);
        }
        /// <summary>
        /// buttonLowAgogo Click.
        /// </summary>
        void buttonLowAgogo_Click(object sender, EventArgs e) {
            playDrumNote(LOW_AGOGO_NOTE);
        }

        /// <summary>
        /// buttonCabasa Click.
        /// </summary>
        void buttonCabasa_Click(object sender, EventArgs e) {
            playDrumNote(CABASA_NOTE);
        }
        /// <summary>
        /// buttonMaracas Click.
        /// </summary>
        void buttonMaracas_Click(object sender, EventArgs e) {
            playDrumNote(MARACAS_NOTE);
        }
        /// <summary>
        /// buttonHiWoodBlock Click.
        /// </summary>
        void buttonHiWoodBlock_Click(object sender, EventArgs e) {
            playDrumNote(HI_WOOD_BLOCK_NOTE);
        }
        /// <summary>
        /// buttonLowWoodBlock Click.
        /// </summary>
        void buttonLowWoodBlock_Click(object sender, EventArgs e) {
            playDrumNote(LOW_WOOD_BLOCK_NOTE);
        }
    }
}
