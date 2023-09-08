namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class DetectorComponent_Template : ActorComponent_Template {
		public bool resetOnCheckpoint = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.EngineVersion > EngineVersion.RO || !(this is FriezeContactDetectorComponent_Template)) {
				resetOnCheckpoint = s.Serialize<bool>(resetOnCheckpoint, name: "resetOnCheckpoint");
			}
		}
		public override uint? ClassCRC => 0x83953116;
	}
}

