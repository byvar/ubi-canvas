using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_AnimMeshVertexManagerComponent_Template : ActorComponent_Template {
		public bool startingFrameEnabled;
		public uint startingFrame;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startingFrameEnabled = s.Serialize<bool>(startingFrameEnabled, name: "startingFrameEnabled");
			startingFrame = s.Serialize<uint>(startingFrame, name: "startingFrame");
		}
		public override uint? ClassCRC => 0x636D6C7B;
	}
}

