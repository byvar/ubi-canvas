using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayTextBanner_evtTemplate : SequenceEvent_Template {
		public uint LineId;
		public uint LineId2;
		public uint LineId3;
		public uint LineId4;
		public uint LineId5;
		public uint LineId6;
		public float Volume;
		public float FadeIn;
		public float FadeOut;
		public uint RandomMode;
		public bool ForcePrefetch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LineId = s.Serialize<uint>(LineId, name: "LineId");
			LineId2 = s.Serialize<uint>(LineId2, name: "LineId2");
			LineId3 = s.Serialize<uint>(LineId3, name: "LineId3");
			LineId4 = s.Serialize<uint>(LineId4, name: "LineId4");
			LineId5 = s.Serialize<uint>(LineId5, name: "LineId5");
			LineId6 = s.Serialize<uint>(LineId6, name: "LineId6");
			Volume = s.Serialize<float>(Volume, name: "Volume");
			FadeIn = s.Serialize<float>(FadeIn, name: "FadeIn");
			FadeOut = s.Serialize<float>(FadeOut, name: "FadeOut");
			RandomMode = s.Serialize<uint>(RandomMode, name: "RandomMode");
			ForcePrefetch = s.Serialize<bool>(ForcePrefetch, name: "ForcePrefetch");
		}
		public override uint? ClassCRC => 0x12243E10;
	}
}

