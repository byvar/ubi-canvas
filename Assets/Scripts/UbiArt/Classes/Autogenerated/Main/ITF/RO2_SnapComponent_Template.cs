using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SnapComponent_Template : ActorComponent_Template {
		[Serialize("zOffset")] public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(zOffset));
		}
		public override uint? ClassCRC => 0x70376653;
	}
}

