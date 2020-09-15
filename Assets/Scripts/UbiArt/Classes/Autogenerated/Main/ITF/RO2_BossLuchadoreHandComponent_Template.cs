using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossLuchadoreHandComponent_Template : GraphicComponent_Template {
		public uint faction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			faction = s.Serialize<uint>(faction, name: "faction");
		}
		public override uint? ClassCRC => 0xA7166264;
	}
}

