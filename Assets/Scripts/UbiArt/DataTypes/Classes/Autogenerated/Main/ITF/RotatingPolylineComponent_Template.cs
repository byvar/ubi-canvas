namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class RotatingPolylineComponent_Template : PolylineComponent_Template {
		public CListO<RotatingPolylineComponent_Template.RotatingPoly> rotatingPolys;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rotatingPolys = s.SerializeObject<CListO<RotatingPolylineComponent_Template.RotatingPoly>>(rotatingPolys, name: "rotatingPolys");
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class RotatingPoly : CSerializable {
			public float brake;
			public float forceMultiplier;
			public StringID bone;
			public CListO<StringID> polylines;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				brake = s.Serialize<float>(brake, name: "brake");
				forceMultiplier = s.Serialize<float>(forceMultiplier, name: "forceMultiplier");
				bone = s.SerializeObject<StringID>(bone, name: "bone");
				polylines = s.SerializeObject<CListO<StringID>>(polylines, name: "polylines");
			}
		}
		public override uint? ClassCRC => 0x94C84C69;
	}
}

