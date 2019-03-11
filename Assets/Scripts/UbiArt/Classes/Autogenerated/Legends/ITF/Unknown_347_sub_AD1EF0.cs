using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_347_sub_AD1EF0 : CSerializable {
		[Serialize("gravity" )] public float gravity;
		[Serialize("friction")] public float friction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gravity));
			SerializeField(s, nameof(friction));
		}
		public override uint? ClassCRC => 0xC3DCD81B;
	}
}

