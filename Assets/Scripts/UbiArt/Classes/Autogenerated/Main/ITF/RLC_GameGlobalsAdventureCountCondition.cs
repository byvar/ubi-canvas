using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsAdventureCountCondition : online.GameGlobalsCondition {
		public uint count;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			count = s.Serialize<uint>(count, name: "count");
		}
		public override uint? ClassCRC => 0xC30D7BF7;
	}
}

