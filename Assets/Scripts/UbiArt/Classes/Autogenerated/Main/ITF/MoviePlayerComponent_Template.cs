using UnityEngine;

namespace UbiArt.ITF {
	public partial class MoviePlayerComponent_Template : ActorComponent_Template {
		[Serialize("video"         )] public Path video;
		[Serialize("audioTrack"    )] public int audioTrack;
		[Serialize("videoTrack"    )] public int videoTrack;
		[Serialize("autoPlay"      )] public bool autoPlay;
		[Serialize("fadeInTime"    )] public float fadeInTime;
		[Serialize("fadeOutTime"   )] public float fadeOutTime;
		[Serialize("playFromMemory")] public bool playFromMemory;
		[Serialize("playToTexture" )] public bool playToTexture;
		[Serialize("loop"          )] public bool loop;
		[Serialize("sound"         )] public bool sound;
		[Serialize("mainthread"    )] public bool mainthread;
		[Serialize("audioTrack"    )] public bool audioTrack;
		[Serialize("videoTrack"    )] public bool videoTrack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(video));
				SerializeField(s, nameof(autoPlay));
				SerializeField(s, nameof(fadeInTime));
				SerializeField(s, nameof(fadeOutTime));
				SerializeField(s, nameof(playFromMemory));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(video));
				SerializeField(s, nameof(audioTrack));
				SerializeField(s, nameof(videoTrack));
				SerializeField(s, nameof(autoPlay));
				SerializeField(s, nameof(fadeInTime));
				SerializeField(s, nameof(fadeOutTime));
				SerializeField(s, nameof(playFromMemory));
				SerializeField(s, nameof(playToTexture));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(sound));
				SerializeField(s, nameof(mainthread));
			} else {
				SerializeField(s, nameof(video));
				SerializeField(s, nameof(audioTrack));
				SerializeField(s, nameof(videoTrack));
				SerializeField(s, nameof(autoPlay));
				SerializeField(s, nameof(fadeInTime));
				SerializeField(s, nameof(fadeOutTime));
				SerializeField(s, nameof(playFromMemory));
				SerializeField(s, nameof(playToTexture));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(sound));
				SerializeField(s, nameof(mainthread));
			}
		}
		public override uint? ClassCRC => 0xE2EA562D;
	}
}

