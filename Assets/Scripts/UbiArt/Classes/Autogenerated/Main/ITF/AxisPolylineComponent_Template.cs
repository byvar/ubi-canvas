using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AxisPolylineComponent_Template : PolylineComponent_Template {
		public CList<AxisPolylineComponent_Template.AxisPoly> axisPolylines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			axisPolylines = s.SerializeObject<CList<AxisPolylineComponent_Template.AxisPoly>>(axisPolylines, name: "axisPolylines");
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class AxisPoly : CSerializable {
			public float stiff;
			public float damp;
			public float weightToAngle;
			public Angle maxAngle;
			public StringID bone;
			public float weightMultiplier;
			public float forceMultiplier;
			public CList<StringID> polylines;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				stiff = s.Serialize<float>(stiff, name: "stiff");
				damp = s.Serialize<float>(damp, name: "damp");
				weightToAngle = s.Serialize<float>(weightToAngle, name: "weightToAngle");
				maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
				bone = s.SerializeObject<StringID>(bone, name: "bone");
				weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
				forceMultiplier = s.Serialize<float>(forceMultiplier, name: "forceMultiplier");
				polylines = s.SerializeObject<CList<StringID>>(polylines, name: "polylines");
			}
		}
		public override uint? ClassCRC => 0x8B20CBD6;
	}
}

