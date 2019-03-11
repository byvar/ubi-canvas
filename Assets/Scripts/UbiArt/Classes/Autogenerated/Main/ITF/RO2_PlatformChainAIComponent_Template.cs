using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PlatformChainAIComponent_Template : ActorComponent_Template {
		[Serialize("rollbackDepth")] public uint rollbackDepth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rollbackDepth));
		}
		public override uint? ClassCRC => 0x994CCDE2;
	}
}

