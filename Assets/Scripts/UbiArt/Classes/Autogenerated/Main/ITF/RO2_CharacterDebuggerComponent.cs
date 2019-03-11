using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CharacterDebuggerComponent : CharacterDebuggerComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x51888FE9;
	}
}

