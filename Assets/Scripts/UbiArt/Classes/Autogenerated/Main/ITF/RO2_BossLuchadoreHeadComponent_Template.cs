using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossLuchadoreHeadComponent_Template : ActorComponent_Template {
		public uint faction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			faction = s.Serialize<uint>(faction, name: "faction");
		}
		public override uint? ClassCRC => 0xD5E9D2B5;
	}
}

