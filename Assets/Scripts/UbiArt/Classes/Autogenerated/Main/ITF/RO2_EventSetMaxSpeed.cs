using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventSetMaxSpeed : Event {
		[Serialize("speed"       )] public float speed;
		[Serialize("restoreSpeed")] public bool restoreSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(restoreSpeed));
		}
		public override uint? ClassCRC => 0x41157F75;
	}
}

