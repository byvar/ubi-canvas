namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIScoreLumBehavior_Template : TemplateAIBehavior {
		public float maxTimeBeforeExplosion_RedMode;
		public uint yellowLumValue;
		public uint redLumValue;
		public uint lumKingValue;
		public Generic<Event> startKingMusicEvent;
		public Generic<Event> stopKingMusicEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxTimeBeforeExplosion_RedMode = s.Serialize<float>(maxTimeBeforeExplosion_RedMode, name: "maxTimeBeforeExplosion_RedMode");
			yellowLumValue = s.Serialize<uint>(yellowLumValue, name: "yellowLumValue");
			redLumValue = s.Serialize<uint>(redLumValue, name: "redLumValue");
			lumKingValue = s.Serialize<uint>(lumKingValue, name: "lumKingValue");
			startKingMusicEvent = s.SerializeObject<Generic<Event>>(startKingMusicEvent, name: "startKingMusicEvent");
			stopKingMusicEvent = s.SerializeObject<Generic<Event>>(stopKingMusicEvent, name: "stopKingMusicEvent");
		}
		public override uint? ClassCRC => 0xA74D72A1;
	}
}

