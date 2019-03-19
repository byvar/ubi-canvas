using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventCameraRegistrerSubject : Event {
		[Serialize("register")] public bool register;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(register));
		}
		public override uint? ClassCRC => 0xCB5377DA;
	}
}

