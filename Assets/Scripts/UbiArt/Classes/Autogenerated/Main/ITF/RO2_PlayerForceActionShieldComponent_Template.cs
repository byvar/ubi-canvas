using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PlayerForceActionShieldComponent_Template : RO2_PlayerForceActionComponent_Template {
		[Serialize("shieldChannelID")] public StringID shieldChannelID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(shieldChannelID));
		}
		public override uint? ClassCRC => 0x78512155;
	}
}

