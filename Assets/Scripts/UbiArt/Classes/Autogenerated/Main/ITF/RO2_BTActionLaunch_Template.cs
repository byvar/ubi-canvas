using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionLaunch_Template : BTAction_Template {
		[Serialize("animLaunching")] public StringID animLaunching;
		[Serialize("animFalling"  )] public StringID animFalling;
		[Serialize("animLanding"  )] public StringID animLanding;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animLaunching));
			SerializeField(s, nameof(animFalling));
			SerializeField(s, nameof(animLanding));
		}
		public override uint? ClassCRC => 0x4E1575C0;
	}
}

