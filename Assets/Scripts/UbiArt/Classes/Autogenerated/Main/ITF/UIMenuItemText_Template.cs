using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UIMenuItemText_Template : UIComponent_Template {
		[Serialize("idleSelectedScale"         )] public float idleSelectedScale;
		[Serialize("idleSelectedPulseFrequency")] public float idleSelectedPulseFrequency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleSelectedScale));
			SerializeField(s, nameof(idleSelectedPulseFrequency));
		}
		public override uint? ClassCRC => 0xC60E040B;
	}
}

