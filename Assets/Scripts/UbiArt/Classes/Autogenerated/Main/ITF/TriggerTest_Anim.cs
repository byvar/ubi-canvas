using UnityEngine;

namespace UbiArt.ITF {
	public partial class TriggerTest_Anim : TriggerTestAbstract {
		[Serialize("AnimState")] public AnimState AnimState;
		[Serialize("animName" )] public Enum_animName animName;
		[Serialize("AnimName" )] public StringID AnimName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AnimState));
			if (s.HasFlags(SerializeFlags.Flags_x03)) {
				SerializeField(s, nameof(animName));
				SerializeField(s, nameof(AnimName));
			}
		}
		public enum AnimState {
			[Serialize("AnimState_Any"     )] Any = 0,
			[Serialize("AnimState_Playing" )] Playing = 1,
			[Serialize("AnimState_Finished")] Finished = 2,
		}
		public enum Enum_animName {
		}
		public override uint? ClassCRC => 0x8D6CCEE9;
	}
}

