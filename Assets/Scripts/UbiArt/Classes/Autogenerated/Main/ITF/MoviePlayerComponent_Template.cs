using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RO | GameFlags.COL)]
	public partial class MoviePlayerComponent_Template : ActorComponent_Template {
		[Serialize("video"            )] public Path video;
		[Serialize("audioTrack"       )] public int audioTrack;
		[Serialize("videoTrack"       )] public int videoTrack;
		[Serialize("autoPlay"         )] public bool autoPlay;
		[Serialize("fadeInTime"       )] public float fadeInTime;
		[Serialize("fadeOutTime"      )] public float fadeOutTime;
		[Serialize("playFromMemory"   )] public bool playFromMemory;
		[Serialize("playToTexture"    )] public bool playToTexture;
		[Serialize("loop"             )] public bool loop;
		[Serialize("sound"            )] public bool sound;
		[Serialize("mainthread"       )] public bool mainthread;
		[Serialize("audioTracks"      )] public Placeholder audioTracks;
		[Serialize("videoTrack"       )] public bool videoTrack;
		[Serialize("playFade"         )] public bool playFade;
		[Serialize("whiteFade"        )] public bool whiteFade;
		[Serialize("pauseGameSounds"  )] public bool pauseGameSounds;
		[Serialize("subsFontTextStyle")] public Placeholder subsFontTextStyle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(video));
				SerializeField(s, nameof(autoPlay));
				SerializeField(s, nameof(fadeInTime));
				SerializeField(s, nameof(fadeOutTime));
				SerializeField(s, nameof(playFromMemory));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(video));
				SerializeField(s, nameof(audioTracks));
				SerializeField(s, nameof(videoTrack), boolAsByte: true);
				SerializeField(s, nameof(autoPlay), boolAsByte: true);
				SerializeField(s, nameof(fadeInTime));
				SerializeField(s, nameof(fadeOutTime));
				SerializeField(s, nameof(playFromMemory), boolAsByte: true);
				SerializeField(s, nameof(playToTexture), boolAsByte: true);
				SerializeField(s, nameof(loop), boolAsByte: true);
				SerializeField(s, nameof(sound), boolAsByte: true);
				SerializeField(s, nameof(mainthread), boolAsByte: true);
				SerializeField(s, nameof(playFade), boolAsByte: true);
				SerializeField(s, nameof(whiteFade), boolAsByte: true);
				SerializeField(s, nameof(pauseGameSounds), boolAsByte: true);
				SerializeField(s, nameof(subsFontTextStyle));
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

