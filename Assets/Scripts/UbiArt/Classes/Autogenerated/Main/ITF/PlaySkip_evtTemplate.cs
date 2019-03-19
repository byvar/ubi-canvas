using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class PlaySkip_evtTemplate : SequenceEvent_Template {
		[Serialize("skipContextIcon")] public ContextIcon skipContextIcon;
		[Serialize("skipContextIcon")] public Enum_skipContextIcon skipContextIcon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(skipContextIcon));
			} else {
				SerializeField(s, nameof(skipContextIcon));
			}
		}
		public enum ContextIcon {
			[Serialize("ContextIcon_Invalid" )] Invalid = -1,
			[Serialize("ContextIcon_Select"  )] Select = 0,
			[Serialize("ContextIcon_Continue")] Continue = 1,
			[Serialize("ContextIcon_Enter"   )] Enter = 2,
			[Serialize("ContextIcon_Skip"    )] Skip = 3,
			[Serialize("ContextIcon_Back"    )] Back = 4,
			[Serialize("ContextIcon_Retry"   )] Retry = 5,
			[Serialize("ContextIcon_Delete"  )] Delete = 6,
		}
		public enum Enum_skipContextIcon {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
		}
		public override uint? ClassCRC => 0x0A5C3303;
	}
}

