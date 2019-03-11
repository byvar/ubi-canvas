using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_StartButton : RLC_BasicAdventureButton {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF1EB181F;
	}
}

