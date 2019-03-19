using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerTest_Anim : TriggerTestAbstract {
		[Serialize("AnimState"   )] public AnimState AnimState;
		[Serialize("animName"    )] public Enum_animName animName;
		[Serialize("AnimName"    )] public StringID AnimName;
		[Serialize("Enum_VH_0__0")] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("Enum_VH_1__1")] public Enum_VH_1 Enum_VH_1__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Enum_VH_0__0));
				SerializeField(s, nameof(Enum_VH_1__1));
			} else {
				SerializeField(s, nameof(AnimState));
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(animName));
					SerializeField(s, nameof(AnimName));
				}
			}
		}
		public enum AnimState {
			[Serialize("AnimState_Any"     )] Any = 0,
			[Serialize("AnimState_Playing" )] Playing = 1,
			[Serialize("AnimState_Finished")] Finished = 2,
		}
		public enum Enum_animName {
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_VH_1 {
		}
		public override uint? ClassCRC => 0x8D6CCEE9;
	}
}

