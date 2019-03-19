using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_ButtonComponent_Template : CSerializable {
		[Serialize("Generic<PhysShape>__0")] public Generic<PhysShape> Generic_PhysShape__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Generic_PhysShape__0));
		}
		public override uint? ClassCRC => 0xAE32DDF6;
	}
}

