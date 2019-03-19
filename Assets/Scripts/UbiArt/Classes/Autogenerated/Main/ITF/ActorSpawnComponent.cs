using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class ActorSpawnComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class SpawnData : CSerializable {
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
			}
		}
		public override uint? ClassCRC => 0xAE141184;
	}
}

