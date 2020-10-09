using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BezierBranchAmvComponent : RO2_BezierBranchComponent {
		public bool flipTexture;
		public CListO<RO2_BezierBranchAmvComponent.Zone> zones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flipTexture = s.Serialize<bool>(flipTexture, name: "flipTexture");
			zones = s.SerializeObject<CListO<RO2_BezierBranchAmvComponent.Zone>>(zones, name: "zones");
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class Zone : CSerializable {
			public float startDist;
			public float endDist;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				startDist = s.Serialize<float>(startDist, name: "startDist");
				endDist = s.Serialize<float>(endDist, name: "endDist");
			}
		}
		public override uint? ClassCRC => 0xD7635566;
	}
}

