namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_StoreBundlePeriod : CSerializable {
		public online.DateTime OpeningTime;
		public online.DateTime ClosingTime;
		public uint DisplayIntervalSeconds;
		public uint HideIntervalSeconds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			OpeningTime = s.SerializeObject<online.DateTime>(OpeningTime, name: "OpeningTime");
			ClosingTime = s.SerializeObject<online.DateTime>(ClosingTime, name: "ClosingTime");
			DisplayIntervalSeconds = s.Serialize<uint>(DisplayIntervalSeconds, name: "DisplayIntervalSeconds");
			HideIntervalSeconds = s.Serialize<uint>(HideIntervalSeconds, name: "HideIntervalSeconds");
		}
	}
}

