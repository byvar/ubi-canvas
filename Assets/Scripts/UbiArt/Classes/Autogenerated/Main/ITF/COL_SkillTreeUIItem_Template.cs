using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SkillTreeUIItem_Template : CSerializable {
		[Serialize("skillUnlockFX")] public StringID skillUnlockFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(skillUnlockFX));
		}
		public override uint? ClassCRC => 0x84BA89E6;
	}
}

