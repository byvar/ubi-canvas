using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIControllerComponent : UIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0022ACE5;
	}
}

