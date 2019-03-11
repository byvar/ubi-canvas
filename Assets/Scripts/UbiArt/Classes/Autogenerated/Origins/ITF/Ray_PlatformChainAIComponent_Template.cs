using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_PlatformChainAIComponent_Template : CSerializable {
		[Serialize("rollbackDepth")] public uint rollbackDepth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rollbackDepth));
		}
		public override uint? ClassCRC => 0x6356C7A8;
	}
}

