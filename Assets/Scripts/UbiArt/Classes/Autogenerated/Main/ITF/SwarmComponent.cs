using UnityEngine;

namespace UbiArt.ITF {
	public partial class SwarmComponent : GraphicComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x89A00B01;
	}
}

