using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlatformChainAIComponent_Template : CSerializable {
		public uint rollbackDepth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rollbackDepth = s.Serialize<uint>(rollbackDepth, name: "rollbackDepth");
		}
		public override uint? ClassCRC => 0x6356C7A8;
	}
}

