namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class WwiseMultiPositionComponent_Template : ActorComponent_Template {
		public StringID SoundName;
		public AUDIO_MULTIPOSITION_MODE MultiPositionMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SoundName = s.SerializeObject<StringID>(SoundName, name: "SoundName");
			MultiPositionMode = s.Serialize<AUDIO_MULTIPOSITION_MODE>(MultiPositionMode, name: "MultiPositionMode");
		}
		public enum AUDIO_MULTIPOSITION_MODE {
			[Serialize("AUDIO_MULTIPOSITION_MODE_SINGLE_SOURCE"   )] SINGLE_SOURCE = 0,
			[Serialize("AUDIO_MULTIPOSITION_MODE_MULTI_SOURCES"   )] MULTI_SOURCES = 1,
			[Serialize("AUDIO_MULTIPOSITION_MODE_MULTI_DIRECTIONS")] MULTI_DIRECTIONS = 2,
		}
		public override uint? ClassCRC => 0x67B9F9C4;
	}
}

