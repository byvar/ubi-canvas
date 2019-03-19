using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class SectoTriggerComponent_Template : CSerializable {
		[Serialize("Generic<PhysShape>__0")] public Generic<PhysShape> Generic_PhysShape__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Generic_PhysShape__0));
		}
		public override uint? ClassCRC => 0x9F5A01B5;
	}
}

