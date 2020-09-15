using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionStilts_Template : BTAction_Template {
		[Serialize("useArmor"           )] public bool useArmor;
		[Serialize("speedFall"          )] public float speedFall;
		[Serialize("animBreak_To_0"     )] public StringID animBreak_To_0;
		[Serialize("animBreak_To_1"     )] public StringID animBreak_To_1;
		[Serialize("animBreak_To_2"     )] public StringID animBreak_To_2;
		[Serialize("animFall_To_0"      )] public StringID animFall_To_0;
		[Serialize("animFall_To_1"      )] public StringID animFall_To_1;
		[Serialize("animFall_To_2"      )] public StringID animFall_To_2;
		[Serialize("animReception_To_0" )] public StringID animReception_To_0;
		[Serialize("animReception_To_1" )] public StringID animReception_To_1;
		[Serialize("animReception_To_2" )] public StringID animReception_To_2;
		[Serialize("offsetFxPos_Level_0")] public Vec2d offsetFxPos_Level_0;
		[Serialize("offsetFxPos_Level_1")] public Vec2d offsetFxPos_Level_1;
		[Serialize("offsetFxPos_Level_2")] public Vec2d offsetFxPos_Level_2;
		[Serialize("animLanding"        )] public StringID animLanding;
		[Serialize("breakFxName"        )] public StringID breakFxName;
		[Serialize("break02FxName"      )] public StringID break02FxName;
		[Serialize("break03FxName"      )] public StringID break03FxName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useArmor));
			SerializeField(s, nameof(speedFall));
			SerializeField(s, nameof(animBreak_To_0));
			SerializeField(s, nameof(animBreak_To_1));
			SerializeField(s, nameof(animBreak_To_2));
			SerializeField(s, nameof(animFall_To_0));
			SerializeField(s, nameof(animFall_To_1));
			SerializeField(s, nameof(animFall_To_2));
			SerializeField(s, nameof(animReception_To_0));
			SerializeField(s, nameof(animReception_To_1));
			SerializeField(s, nameof(animReception_To_2));
			SerializeField(s, nameof(offsetFxPos_Level_0));
			SerializeField(s, nameof(offsetFxPos_Level_1));
			SerializeField(s, nameof(offsetFxPos_Level_2));
			SerializeField(s, nameof(animLanding));
			SerializeField(s, nameof(breakFxName));
			SerializeField(s, nameof(break02FxName));
			SerializeField(s, nameof(break03FxName));
		}
		public override uint? ClassCRC => 0xAA96F821;
	}
}

