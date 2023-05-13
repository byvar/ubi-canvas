namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class PadRumble : CSerializable {
		public StringID name;
		public float intensity;
		public float lightIntensity;
		public float duration;
		public StringID StringID__0;
		public float float__1;
		public float float__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH || s.Settings.game == Settings.Game.RL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				intensity = s.Serialize<float>(intensity, name: "intensity");
				duration = s.Serialize<float>(duration, name: "duration");
			} else {
				name = s.SerializeObject<StringID>(name, name: "name");
				intensity = s.Serialize<float>(intensity, name: "intensity");
				lightIntensity = s.Serialize<float>(lightIntensity, name: "lightIntensity");
				duration = s.Serialize<float>(duration, name: "duration");
			}
		}
	}
}

