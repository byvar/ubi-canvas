using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionPostBattle_Template : CSerializable {
		[Serialize("charactersInFight")] public Placeholder charactersInFight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(charactersInFight));
		}
		public override uint? ClassCRC => 0xAA492116;
	}
}

