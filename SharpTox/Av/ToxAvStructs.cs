﻿namespace SharpTox.Av
{
    /// <summary>
    /// Represents toxav encoding settings.
    /// </summary>
    public struct ToxAvCodecSettings
    {
        /// <summary>
        /// Video bitrate in bits/s.
        /// </summary>
        public uint video_bitrate;

        /// <summary>
        /// Maximum video width in pixels.
        /// </summary>
        public ushort max_video_width;

        /// <summary>
        /// Maximum video height in pixels.
        /// </summary>
        public ushort max_video_height;

        /// <summary>
        /// Audio bitrate in bits/s.
        /// </summary>
        public uint audio_bitrate;

        /// <summary>
        /// Audio frame duration in ms.
        /// </summary>
        public ushort audio_frame_duration;

        /// <summary>
        /// Audio sample rate in Hz.
        /// </summary>
        public uint audio_sample_rate;

        /// <summary>
        /// Audio channels.
        /// </summary>
        public uint audio_channels;

        /// <summary>
        /// Audio VAD tolerance in ms.
        /// </summary>
        public int audio_VAD_tolerance;

        /// <summary>
        /// Size of jitter buffer.
        /// </summary>
        public uint jbuf_capacity;
    }
}
