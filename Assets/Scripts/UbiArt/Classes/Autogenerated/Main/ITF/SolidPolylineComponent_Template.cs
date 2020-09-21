using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class SolidPolylineComponent_Template : PolylineComponent_Template {
		public CListO<SolidPolylineComponent_Template.SolidEdgeData> solidEdges;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			solidEdges = s.SerializeObject<CListO<SolidPolylineComponent_Template.SolidEdgeData>>(solidEdges, name: "solidEdges");
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class SolidEdgeData : CSerializable {
			public StringID bone;
			public float minDelta;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				bone = s.SerializeObject<StringID>(bone, name: "bone");
				minDelta = s.Serialize<float>(minDelta, name: "minDelta");
			}
		}
		public override uint? ClassCRC => 0xDEC09000;
	}
}

