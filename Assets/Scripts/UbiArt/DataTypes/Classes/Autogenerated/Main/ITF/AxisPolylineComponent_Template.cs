using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class AxisPolylineComponent_Template : PolylineComponent_Template {
		public CListO<AxisPolylineComponent_Template.AxisPoly> axisPolylines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			axisPolylines = s.SerializeObject<CListO<AxisPolylineComponent_Template.AxisPoly>>(axisPolylines, name: "axisPolylines");
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class AxisPoly : CSerializable {
			public float stiff;
			public float damp;
			public float weightToAngle;
			public Angle maxAngle;
			public StringID bone;
			public float weightMultiplier;
			public float forceMultiplier;
			public CListO<StringID> polylines;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				stiff = s.Serialize<float>(stiff, name: "stiff");
				damp = s.Serialize<float>(damp, name: "damp");
				weightToAngle = s.Serialize<float>(weightToAngle, name: "weightToAngle");
				maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
				bone = s.SerializeObject<StringID>(bone, name: "bone");
				weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
				forceMultiplier = s.Serialize<float>(forceMultiplier, name: "forceMultiplier");
				polylines = s.SerializeObject<CListO<StringID>>(polylines, name: "polylines");
			}
		}
		public override uint? ClassCRC => 0x8B20CBD6;
	}
}

