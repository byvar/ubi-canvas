namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion)]
	public partial class BusMix : CSerializable {
		public StringID name;
		public uint priority;
		public float duration;
		public float fadeIn;
		public float fadeOut;
		public CListO<BusDef> busDefs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO || s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR) {
				name = s.SerializeObject<StringID>(name, name: "name");
				priority = s.Serialize<uint>(priority, name: "priority");
				duration = s.Serialize<float>(duration, name: "duration");
				fadeIn = s.Serialize<float>(fadeIn, name: "fadeIn");
				fadeOut = s.Serialize<float>(fadeOut, name: "fadeOut");
				busDefs = s.SerializeObject<CListO<BusDef>>(busDefs, name: "busDefs");
			} else {
				priority = s.Serialize<uint>(priority, name: "priority");
				duration = s.Serialize<float>(duration, name: "duration");
				fadeIn = s.Serialize<float>(fadeIn, name: "fadeIn");
				fadeOut = s.Serialize<float>(fadeOut, name: "fadeOut");
				busDefs = s.SerializeObject<CListO<BusDef>>(busDefs, name: "busDefs");
			}
		}
	}
}

