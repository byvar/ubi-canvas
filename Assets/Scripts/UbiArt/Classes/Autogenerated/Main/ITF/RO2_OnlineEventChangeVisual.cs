using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_OnlineEventChangeVisual : Event {
		[Serialize("colorID")] public char colorID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(colorID));
		}
		public override uint? ClassCRC => 0x6D646F31;
	}
}

