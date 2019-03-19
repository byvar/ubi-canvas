using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SkillTreeUIItem : CSerializable {
		[Description("Skill's StringID.")]
		[Serialize("skillID")] public StringID skillID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(skillID));
		}
		public override uint? ClassCRC => 0x2A19D588;
	}
}

