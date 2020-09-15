using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class RotatingPolylineComponent_Template : PolylineComponent_Template {
		public CList<RotatingPolylineComponent_Template.RotatingPoly> rotatingPolys;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rotatingPolys = s.SerializeObject<CList<RotatingPolylineComponent_Template.RotatingPoly>>(rotatingPolys, name: "rotatingPolys");
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class RotatingPoly : CSerializable {
			public float brake;
			public float forceMultiplier;
			public StringID bone;
			public CList<StringID> polylines;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				brake = s.Serialize<float>(brake, name: "brake");
				forceMultiplier = s.Serialize<float>(forceMultiplier, name: "forceMultiplier");
				bone = s.SerializeObject<StringID>(bone, name: "bone");
				polylines = s.SerializeObject<CList<StringID>>(polylines, name: "polylines");
			}
		}
		public override uint? ClassCRC => 0x94C84C69;
	}
}

