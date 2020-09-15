using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerForceActionShieldComponent_Template : RO2_PlayerForceActionComponent_Template {
		public StringID shieldChannelID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			shieldChannelID = s.SerializeObject<StringID>(shieldChannelID, name: "shieldChannelID");
		}
		public override uint? ClassCRC => 0x78512155;
	}
}

