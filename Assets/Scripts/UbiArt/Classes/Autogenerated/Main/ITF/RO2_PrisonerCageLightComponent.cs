using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PrisonerCageLightComponent : RO2_AIComponent {
		[Serialize("isBroken")] public bool isBroken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(isBroken));
			}
		}
		public override uint? ClassCRC => 0x60032DB8;
	}
}

