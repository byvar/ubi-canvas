using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BuboBTAIComponent_Template : BTAIComponent_Template {
		public uint allowedFaction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			allowedFaction = s.Serialize<uint>(allowedFaction, name: "allowedFaction");
		}
		public override uint? ClassCRC => 0xBE0FDDB4;
	}
}

