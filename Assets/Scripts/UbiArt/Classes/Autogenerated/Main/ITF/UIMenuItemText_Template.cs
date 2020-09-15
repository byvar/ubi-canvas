using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UIMenuItemText_Template : UIComponent_Template {
		public float idleSelectedScale;
		public float idleSelectedPulseFrequency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleSelectedScale = s.Serialize<float>(idleSelectedScale, name: "idleSelectedScale");
			idleSelectedPulseFrequency = s.Serialize<float>(idleSelectedPulseFrequency, name: "idleSelectedPulseFrequency");
		}
		public override uint? ClassCRC => 0xC60E040B;
	}
}

