using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AINetworkComponent_Template : ActorComponent_Template {
		[Serialize("shape")] public Generic<PhysShape> shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(shape));
		}
		public override uint? ClassCRC => 0xAD70FA46;
	}
}

