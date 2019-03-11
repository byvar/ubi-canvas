using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LumGlassBallComponent_Template : ActorComponent_Template {
		[Serialize("LumNumberReward"  )] public uint LumNumberReward;
		[Serialize("FrameNbTransition")] public uint FrameNbTransition;
		[Serialize("landFX"           )] public StringID landFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LumNumberReward));
			SerializeField(s, nameof(FrameNbTransition));
			SerializeField(s, nameof(landFX));
		}
		public override uint? ClassCRC => 0x466D4C64;
	}
}

