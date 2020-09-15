using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_KuyALumsComponent : RO2_AIComponent {
		public bool killed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				killed = s.Serialize<bool>(killed, name: "killed");
			}
		}
		public override uint? ClassCRC => 0x0C928FA3;
	}
}

