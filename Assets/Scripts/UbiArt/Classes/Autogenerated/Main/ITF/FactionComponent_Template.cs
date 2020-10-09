using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class FactionComponent_Template : ActorComponent_Template {
		public uint faction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			faction = s.Serialize<uint>(faction, name: "faction");
		}
		public override uint? ClassCRC => 0xCBB4C235;
	}
}

