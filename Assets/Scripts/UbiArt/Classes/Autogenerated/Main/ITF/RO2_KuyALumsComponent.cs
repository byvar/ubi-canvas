using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_KuyALumsComponent : RO2_AIComponent {
		[Serialize("killed")] public bool killed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(killed));
			}
		}
		public override uint? ClassCRC => 0x0C928FA3;
	}
}

