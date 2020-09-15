using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionRoaming_Template : BTAction_Template {
		public StringID animWalk;
		public StringID animUTurn;
		public bool useFlipEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				animWalk = s.SerializeObject<StringID>(animWalk, name: "animWalk");
				animUTurn = s.SerializeObject<StringID>(animUTurn, name: "animUTurn");
			} else {
				animWalk = s.SerializeObject<StringID>(animWalk, name: "animWalk");
				animUTurn = s.SerializeObject<StringID>(animUTurn, name: "animUTurn");
				useFlipEvent = s.Serialize<bool>(useFlipEvent, name: "useFlipEvent");
			}
		}
		public override uint? ClassCRC => 0x520E8E0C;
	}
}

