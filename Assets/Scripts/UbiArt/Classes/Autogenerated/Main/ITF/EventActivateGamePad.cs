using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventActivateGamePad : Event {
		[Serialize("Activate")] public bool Activate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Activate));
		}
		public override uint? ClassCRC => 0x8D252EDD;
	}
}

