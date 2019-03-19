using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionLitRune_Template : BTAction_Template {
		[Serialize("animIncantation")] public StringID animIncantation;
		[Serialize("animGrateful"   )] public StringID animGrateful;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animIncantation));
			SerializeField(s, nameof(animGrateful));
		}
		public override uint? ClassCRC => 0x2EE4FAA6;
	}
}

