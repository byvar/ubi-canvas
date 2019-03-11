using UnityEngine;

namespace UbiArt.ITF {
	public partial class ProceduralBoneComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9189C777;
	}
}

