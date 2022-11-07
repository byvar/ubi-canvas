namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class MoviePlayerComponent_Template : ActorComponent_Template {
		public Path video;
		public int audioTrack;
		public bool videoTrack;
		public bool autoPlay;
		public float fadeInTime;
		public float fadeOutTime;
		public bool playFromMemory;
		public bool playToTexture;
		public bool loop;
		public bool sound;
		public bool mainthread;
		public CListP<uint> audioTracks;
		public bool playFade;
		public bool whiteFade;
		public bool pauseGameSounds;
		public FontTextArea.Style subsFontTextStyle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				video = s.SerializeObject<Path>(video, name: "video");
				autoPlay = s.Serialize<bool>(autoPlay, name: "autoPlay");
				fadeInTime = s.Serialize<float>(fadeInTime, name: "fadeInTime");
				fadeOutTime = s.Serialize<float>(fadeOutTime, name: "fadeOutTime");
				playFromMemory = s.Serialize<bool>(playFromMemory, name: "playFromMemory");
			} else if (s.Settings.game == Settings.Game.COL) {
				video = s.SerializeObject<Path>(video, name: "video");
				audioTracks = s.SerializeObject<CListP<uint>>(audioTracks, name: "audioTracks");
				videoTrack = s.Serialize<bool>(videoTrack, name: "videoTrack", options: CSerializerObject.Options.BoolAsByte);
				autoPlay = s.Serialize<bool>(autoPlay, name: "autoPlay", options: CSerializerObject.Options.BoolAsByte);
				fadeInTime = s.Serialize<float>(fadeInTime, name: "fadeInTime");
				fadeOutTime = s.Serialize<float>(fadeOutTime, name: "fadeOutTime");
				playFromMemory = s.Serialize<bool>(playFromMemory, name: "playFromMemory", options: CSerializerObject.Options.BoolAsByte);
				playToTexture = s.Serialize<bool>(playToTexture, name: "playToTexture", options: CSerializerObject.Options.BoolAsByte);
				loop = s.Serialize<bool>(loop, name: "loop", options: CSerializerObject.Options.BoolAsByte);
				sound = s.Serialize<bool>(sound, name: "sound", options: CSerializerObject.Options.BoolAsByte);
				mainthread = s.Serialize<bool>(mainthread, name: "mainthread", options: CSerializerObject.Options.BoolAsByte);
				playFade = s.Serialize<bool>(playFade, name: "playFade", options: CSerializerObject.Options.BoolAsByte);
				whiteFade = s.Serialize<bool>(whiteFade, name: "whiteFade", options: CSerializerObject.Options.BoolAsByte);
				pauseGameSounds = s.Serialize<bool>(pauseGameSounds, name: "pauseGameSounds", options: CSerializerObject.Options.BoolAsByte);
				subsFontTextStyle = s.SerializeObject<FontTextArea.Style>(subsFontTextStyle, name: "subsFontTextStyle");
			} else {
				video = s.SerializeObject<Path>(video, name: "video");
				audioTrack = s.Serialize<int>(audioTrack, name: "audioTrack");
				videoTrack = s.Serialize<bool>(videoTrack, name: "videoTrack");
				autoPlay = s.Serialize<bool>(autoPlay, name: "autoPlay");
				fadeInTime = s.Serialize<float>(fadeInTime, name: "fadeInTime");
				fadeOutTime = s.Serialize<float>(fadeOutTime, name: "fadeOutTime");
				playFromMemory = s.Serialize<bool>(playFromMemory, name: "playFromMemory");
				playToTexture = s.Serialize<bool>(playToTexture, name: "playToTexture");
				loop = s.Serialize<bool>(loop, name: "loop");
				sound = s.Serialize<bool>(sound, name: "sound");
				mainthread = s.Serialize<bool>(mainthread, name: "mainthread");
			}
		}
		public override uint? ClassCRC => 0xE2EA562D;
	}
}

