using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ShooterSpawnerModifierComponent_Template : TimedSpawnerModifierComponent_Template {
		[Serialize("tweenInstructionSetList")] public Placeholder tweenInstructionSetList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tweenInstructionSetList));
		}
		public override uint? ClassCRC => 0x0922507B;
	}
}

