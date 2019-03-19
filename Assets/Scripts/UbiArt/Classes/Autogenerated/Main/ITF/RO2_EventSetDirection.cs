using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_EventSetDirection : Event {
		[Serialize("direction")] public Vector2 direction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(direction));
		}
		public override uint? ClassCRC => 0x6EC4A473;
	}
}

