namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RA)]
	public partial class BezierBranchAmvComponent : BezierBranchComponent {
		public bool flipTexture;
		public CListO<BezierBranchAmvComponent.Zone> zones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				flipTexture = s.Serialize<bool>(flipTexture, name: "flipTexture", options: CSerializerObject.Options.BoolAsByte);
			} else {
				flipTexture = s.Serialize<bool>(flipTexture, name: "flipTexture");
				zones = s.SerializeObject<CListO<BezierBranchAmvComponent.Zone>>(zones, name: "zones");
			}
		}
		[Games(GameFlags.RA)]
		public partial class Zone : CSerializable {
			public float startDist;
			public float endDist;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				startDist = s.Serialize<float>(startDist, name: "startDist");
				endDist = s.Serialize<float>(endDist, name: "endDist");
			}
		}
		public override uint? ClassCRC => 0xA3BCCC12;
	}
}

