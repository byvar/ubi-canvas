namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class AABBPrefetchComponent_Template : ActorComponent_Template {
		public bool isAlwaysActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.EngineVersion > EngineVersion.RO) {
				isAlwaysActive = s.Serialize<bool>(isAlwaysActive, name: "isAlwaysActive");
			}
		}
		public override uint? ClassCRC => 0x70B3ABBA;
	}
}

