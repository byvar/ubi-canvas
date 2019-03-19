using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionRoamingUnderWater_Template : BTAction_Template {
		[Serialize("animSwimUp"  )] public StringID animSwimUp;
		[Serialize("animSwimDown")] public StringID animSwimDown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animSwimUp));
			SerializeField(s, nameof(animSwimDown));
		}
		public override uint? ClassCRC => 0x23188509;
	}
}

