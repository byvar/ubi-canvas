using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionReceiveCrush_Template : BTAction_Template {
		[Serialize("anim"                 )] public StringID anim;
		[Serialize("crushDuringAttackAnim")] public StringID crushDuringAttackAnim;
		[Serialize("canReEnter"           )] public bool canReEnter;
		[Serialize("offsetFxPos_Level_0"  )] public Vector2 offsetFxPos_Level_0;
		[Serialize("offsetFxPos_Level_1"  )] public Vector2 offsetFxPos_Level_1;
		[Serialize("offsetFxPos_Level_2"  )] public Vector2 offsetFxPos_Level_2;
		[Serialize("breakFxName"          )] public StringID breakFxName;
		[Serialize("break02FxName"        )] public StringID break02FxName;
		[Serialize("break03FxName"        )] public StringID break03FxName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(crushDuringAttackAnim));
			SerializeField(s, nameof(canReEnter));
			SerializeField(s, nameof(offsetFxPos_Level_0));
			SerializeField(s, nameof(offsetFxPos_Level_1));
			SerializeField(s, nameof(offsetFxPos_Level_2));
			SerializeField(s, nameof(breakFxName));
			SerializeField(s, nameof(break02FxName));
			SerializeField(s, nameof(break03FxName));
		}
		public override uint? ClassCRC => 0xC6B0B0B7;
	}
}

