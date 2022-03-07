﻿
using System.Runtime.InteropServices;
using fluid_settings_t = System.IntPtr;
using fluid_synth_t = System.IntPtr;
using fluid_audio_driver_t = System.IntPtr;

namespace NativeFuncs {

    internal static class Fluidsynth {
#nullable enable

        const string LIBLARY = "libfluidsynth.so";

        const UnmanagedType LP_Str = UnmanagedType.LPStr;

        internal const int FLUID_OK = 0;

        internal const int FLUID_FAILED = -1;

        [DllImport(LIBLARY)]
        internal static extern fluid_settings_t new_fluid_settings();

        [DllImport(LIBLARY)]
        internal static extern void delete_fluid_settings(fluid_settings_t settings);

        [DllImport(LIBLARY)]
        internal static extern fluid_synth_t new_fluid_synth(fluid_settings_t settings);

        [DllImport(LIBLARY)]
        internal static extern void delete_fluid_synth(fluid_synth_t synth);

        [DllImport(LIBLARY)]
        internal static extern fluid_audio_driver_t new_fluid_audio_driver(fluid_settings_t settings, fluid_synth_t synth);

        [DllImport(LIBLARY)]
        internal static extern void delete_fluid_audio_driver(fluid_audio_driver_t driver);

        [DllImport(LIBLARY)]
        internal static extern int fluid_synth_sfload(fluid_synth_t synth, [MarshalAs(LP_Str)] string filename, bool reset_presets);

        [DllImport(LIBLARY)]
        internal static extern int fluid_is_soundfont([MarshalAs(LP_Str)] string filename); // 1 or 0

        [DllImport(LIBLARY)]
        internal static extern int fluid_synth_noteon(fluid_synth_t synth, int chan, int key, int vel);

        [DllImport(LIBLARY)]
        internal static extern int fluid_synth_noteoff(fluid_synth_t synth, int chan, int key);
    }
}

// fluid_midi_event_type
// NOTE_OFF       = 128
// NOTE_ON        = 144
// CONTROL_CHANGE = 176
// PROGRAM_CHANGE = 192

// fluid_midi_control_chang
// BANK_SELECT_MSB =  0
// DATA_ENTRY_MSB  =  6
// VOLUME_MSB      =  7
// PAN_MSB         = 10
// EXPRESSION_MSB  = 11
// BANK_SELECT_LSB = 32
// DATA_ENTRY_LSB  = 38