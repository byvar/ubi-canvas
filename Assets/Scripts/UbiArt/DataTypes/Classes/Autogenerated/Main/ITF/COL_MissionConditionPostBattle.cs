using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionPostBattle : CSerializable {
		public Placeholder COL_GameScreen_Exploration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			COL_GameScreen_Exploration = s.SerializeObject<Placeholder>(COL_GameScreen_Exploration, name: "COL_GameScreen_Exploration");
		}
		public override uint? ClassCRC => 0x4FB70F75;
	}
}

