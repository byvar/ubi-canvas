using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ExampleComponent_Template : ActorComponent_Template {
		[Serialize("someShape")] public Generic<PhysShape> someShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(someShape));
		}
		public override uint? ClassCRC => 0x239AF172;
	}
}

