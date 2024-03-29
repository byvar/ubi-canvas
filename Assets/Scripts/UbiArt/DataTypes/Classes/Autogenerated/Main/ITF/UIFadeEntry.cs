namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class UIFadeEntry : CSerializable {
		public StringID id;
		public float duration;
		public Color color;
		public StringID anim;
		public StringID fadeInSound;
		public StringID fadeOutSound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<StringID>(id, name: "id");
			duration = s.Serialize<float>(duration, name: "duration");
			color = s.SerializeObject<Color>(color, name: "color");
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			if (s.Settings.EngineVersion > EngineVersion.RO) {
				fadeInSound = s.SerializeObject<StringID>(fadeInSound, name: "fadeInSound");
				fadeOutSound = s.SerializeObject<StringID>(fadeOutSound, name: "fadeOutSound");
			}
		}
	}
}

