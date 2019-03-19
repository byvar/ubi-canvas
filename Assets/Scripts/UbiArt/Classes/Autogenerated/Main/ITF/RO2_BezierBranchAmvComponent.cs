using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_BezierBranchAmvComponent : RO2_BezierBranchComponent {
		[Serialize("flipTexture")] public bool flipTexture;
		[Serialize("zones"      )] public CList<RO2_BezierBranchAmvComponent.Zone> zones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flipTexture));
			SerializeField(s, nameof(zones));
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class Zone : CSerializable {
			[Serialize("startDist")] public float startDist;
			[Serialize("endDist"  )] public float endDist;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(startDist));
				SerializeField(s, nameof(endDist));
			}
		}
		public override uint? ClassCRC => 0xD7635566;
	}
}

