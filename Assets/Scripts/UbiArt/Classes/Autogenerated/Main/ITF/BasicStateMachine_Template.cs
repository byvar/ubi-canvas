using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BasicStateMachine_Template : CSerializable {
		public CListO<BasicState_Template> stateList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				stateList = s.SerializeObject<CListO<BasicState_Template>>(stateList, name: "stateList");
			}
		}
		public override uint? ClassCRC => 0x81FA00D7;
	}
}

