using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerTest_Anim : TriggerTestAbstract {
		[Serialize("AnimState"   )] public AnimState animState;
		[Serialize("AnimName"    )] public StringID AnimName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animState));
			if (s.HasFlags(SerializeFlags.Editor)) {
				SerializeFieldAsChoiceList(s, nameof(AnimName)); // No empty here
			} else {
				SerializeField(s, nameof(AnimName));
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

