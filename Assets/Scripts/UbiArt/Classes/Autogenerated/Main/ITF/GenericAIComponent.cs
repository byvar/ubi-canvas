using UnityEngine;

namespace UbiArt.ITF {
	public partial class GenericAIComponent : AIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC3AE459E;
	}
}

