using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionStepBattle_Template : CSerializable {
		public Placeholder id;
		public bool battleWon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<Placeholder>(id, name: "id");
			battleWon = s.Serialize<bool>(battleWon, name: "battleWon", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x2FF9CA00;
	}
}

