using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionUTurn_Template : BTAction_Template {
		public StringID animTurn;
		public StringID endAnim;
		public bool useFlipEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				animTurn = s.SerializeObject<StringID>(animTurn, name: "animTurn");
				endAnim = s.SerializeObject<StringID>(endAnim, name: "endAnim");
			} else {
				animTurn = s.SerializeObject<StringID>(animTurn, name: "animTurn");
				endAnim = s.SerializeObject<StringID>(endAnim, name: "endAnim");
				useFlipEvent = s.Serialize<bool>(useFlipEvent, name: "useFlipEvent");
			}
		}
		public override uint? ClassCRC => 0x2601289C;
	}
}

