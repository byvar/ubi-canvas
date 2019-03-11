using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LumJarComponent_Template : ActorComponent_Template {
		[Serialize("LumNumberReward"  )] public uint LumNumberReward;
		[Serialize("FrameNbTransition")] public uint FrameNbTransition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LumNumberReward));
			SerializeField(s, nameof(FrameNbTransition));
		}
		public override uint? ClassCRC => 0xD0788A27;
	}
}

