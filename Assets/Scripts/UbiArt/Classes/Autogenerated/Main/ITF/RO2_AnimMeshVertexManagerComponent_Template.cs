using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AnimMeshVertexManagerComponent_Template : ActorComponent_Template {
		[Serialize("startingFrameEnabled")] public bool startingFrameEnabled;
		[Serialize("startingFrame"       )] public uint startingFrame;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startingFrameEnabled));
			SerializeField(s, nameof(startingFrame));
		}
		public override uint? ClassCRC => 0x636D6C7B;
	}
}

