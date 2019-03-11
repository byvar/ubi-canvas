using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FairyNodeComponent : RO2_SnakeNetworkNodeComponent {
		[Serialize("lumsCount"       )] public uint lumsCount;
		[Serialize("lumsDropMinDist" )] public float lumsDropMinDist;
		[Serialize("lumsDropStepDist")] public float lumsDropStepDist;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lumsCount));
			SerializeField(s, nameof(lumsDropMinDist));
			SerializeField(s, nameof(lumsDropStepDist));
		}
		public override uint? ClassCRC => 0x3B569C33;
	}
}

