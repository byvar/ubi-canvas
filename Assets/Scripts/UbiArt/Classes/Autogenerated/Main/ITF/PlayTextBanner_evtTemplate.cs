using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayTextBanner_evtTemplate : SequenceEvent_Template {
		[Serialize("LineId"       )] public uint LineId;
		[Serialize("LineId2"      )] public uint LineId2;
		[Serialize("LineId3"      )] public uint LineId3;
		[Serialize("LineId4"      )] public uint LineId4;
		[Serialize("LineId5"      )] public uint LineId5;
		[Serialize("LineId6"      )] public uint LineId6;
		[Serialize("Volume"       )] public float Volume;
		[Serialize("FadeIn"       )] public float FadeIn;
		[Serialize("FadeOut"      )] public float FadeOut;
		[Serialize("RandomMode"   )] public uint RandomMode;
		[Serialize("ForcePrefetch")] public bool ForcePrefetch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LineId));
			SerializeField(s, nameof(LineId2));
			SerializeField(s, nameof(LineId3));
			SerializeField(s, nameof(LineId4));
			SerializeField(s, nameof(LineId5));
			SerializeField(s, nameof(LineId6));
			SerializeField(s, nameof(Volume));
			SerializeField(s, nameof(FadeIn));
			SerializeField(s, nameof(FadeOut));
			SerializeField(s, nameof(RandomMode));
			SerializeField(s, nameof(ForcePrefetch));
		}
		public override uint? ClassCRC => 0x12243E10;
	}
}

