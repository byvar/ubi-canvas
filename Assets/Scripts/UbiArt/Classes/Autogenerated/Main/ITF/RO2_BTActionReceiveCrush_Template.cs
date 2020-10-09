using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionReceiveCrush_Template : BTAction_Template {
		public StringID anim;
		public StringID crushDuringAttackAnim;
		public bool canReEnter;
		public Vec2d offsetFxPos_Level_0;
		public Vec2d offsetFxPos_Level_1;
		public Vec2d offsetFxPos_Level_2;
		public StringID breakFxName;
		public StringID break02FxName;
		public StringID break03FxName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			crushDuringAttackAnim = s.SerializeObject<StringID>(crushDuringAttackAnim, name: "crushDuringAttackAnim");
			canReEnter = s.Serialize<bool>(canReEnter, name: "canReEnter");
			offsetFxPos_Level_0 = s.SerializeObject<Vec2d>(offsetFxPos_Level_0, name: "offsetFxPos_Level_0");
			offsetFxPos_Level_1 = s.SerializeObject<Vec2d>(offsetFxPos_Level_1, name: "offsetFxPos_Level_1");
			offsetFxPos_Level_2 = s.SerializeObject<Vec2d>(offsetFxPos_Level_2, name: "offsetFxPos_Level_2");
			breakFxName = s.SerializeObject<StringID>(breakFxName, name: "breakFxName");
			break02FxName = s.SerializeObject<StringID>(break02FxName, name: "break02FxName");
			break03FxName = s.SerializeObject<StringID>(break03FxName, name: "break03FxName");
		}
		public override uint? ClassCRC => 0xC6B0B0B7;
	}
}

