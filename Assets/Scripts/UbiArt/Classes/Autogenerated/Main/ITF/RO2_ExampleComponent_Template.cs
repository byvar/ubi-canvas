using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_ExampleComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> someShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			someShape = s.SerializeObject<Generic<PhysShape>>(someShape, name: "someShape");
		}
		public override uint? ClassCRC => 0x239AF172;
	}
}

