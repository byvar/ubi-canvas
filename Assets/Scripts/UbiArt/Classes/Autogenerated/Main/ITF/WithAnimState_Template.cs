using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class WithAnimState_Template : BasicState_Template {
		public StringID defaultAnim;
		public bool endCheckByAnimEvent;
		public bool endCheckByAnimEnd;
		public bool restartAnimIfSame;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			defaultAnim = s.SerializeObject<StringID>(defaultAnim, name: "defaultAnim");
			endCheckByAnimEvent = s.Serialize<bool>(endCheckByAnimEvent, name: "endCheckByAnimEvent");
			endCheckByAnimEnd = s.Serialize<bool>(endCheckByAnimEnd, name: "endCheckByAnimEnd");
			restartAnimIfSame = s.Serialize<bool>(restartAnimIfSame, name: "restartAnimIfSame");
		}
		public override uint? ClassCRC => 0x3DFD8E0F;
	}
}

