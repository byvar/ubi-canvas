using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventCameraRegistrerSubject : Event {
		[Serialize("register")] public bool register;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(register));
		}
		public override uint? ClassCRC => 0xCB5377DA;
	}
}

