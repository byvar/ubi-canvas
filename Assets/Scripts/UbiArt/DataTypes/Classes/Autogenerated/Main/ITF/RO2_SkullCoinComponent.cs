using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SkullCoinComponent : GraphicComponent {
		public bool isTaken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				isTaken = s.Serialize<bool>(isTaken, name: "isTaken");
			}
		}
		public override uint? ClassCRC => 0x5676E420;
	}
}

