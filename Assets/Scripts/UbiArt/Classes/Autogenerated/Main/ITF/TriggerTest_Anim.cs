using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerTest_Anim : TriggerTestAbstract {
		public AnimState animState;
		public StringID AnimName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animState = s.Serialize<AnimState>(animState, name: "animState");
			if (s.HasFlags(SerializeFlags.Editor)) {
				SerializeFieldAsChoiceList(s, nameof(AnimName)); // No empty here
			} else {
				AnimName = s.SerializeObject<StringID>(AnimName, name: "AnimName");
			}
		}
		public enum AnimState {
			[Serialize("AnimState_Any"     )] Any = 0,
			[Serialize("AnimState_Playing" )] Playing = 1,
			[Serialize("AnimState_Finished")] Finished = 2,
		}

		public override uint? ClassCRC => 0x8D6CCEE9;
	}
}

