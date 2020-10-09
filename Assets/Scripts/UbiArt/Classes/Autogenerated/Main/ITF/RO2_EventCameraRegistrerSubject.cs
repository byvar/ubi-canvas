using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventCameraRegistrerSubject : Event {
		public bool register;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			register = s.Serialize<bool>(register, name: "register");
		}
		public override uint? ClassCRC => 0xCB5377DA;
	}
}

