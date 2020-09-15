using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionPostBattle_Template : CSerializable {
		public Placeholder charactersInFight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			charactersInFight = s.SerializeObject<Placeholder>(charactersInFight, name: "charactersInFight");
		}
		public override uint? ClassCRC => 0xAA492116;
	}
}

