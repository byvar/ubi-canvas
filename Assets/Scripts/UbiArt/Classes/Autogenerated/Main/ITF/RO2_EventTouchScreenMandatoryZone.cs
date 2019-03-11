using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventTouchScreenMandatoryZone : Event {
		[Serialize("enter"                   )] public bool enter;
		[Serialize("unswapDRCPlayerIfSwapped")] public bool unswapDRCPlayerIfSwapped;
		[Serialize("autoMurphy"              )] public bool autoMurphy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enter));
			SerializeField(s, nameof(unswapDRCPlayerIfSwapped));
			SerializeField(s, nameof(autoMurphy));
		}
		public override uint? ClassCRC => 0xF9AD72C0;
	}
}

