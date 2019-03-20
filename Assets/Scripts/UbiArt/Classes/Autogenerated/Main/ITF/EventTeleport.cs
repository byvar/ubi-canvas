using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventTeleport : Event {
		[Serialize("applyPosAndAngle")] public bool applyPosAndAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(applyPosAndAngle));
		}
		public override uint? ClassCRC => 0x4017E956;
	}
}

