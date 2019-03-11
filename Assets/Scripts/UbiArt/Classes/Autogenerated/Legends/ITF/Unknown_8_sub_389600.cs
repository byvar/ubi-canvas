using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_8_sub_389600 : CSerializable {
		[Serialize("name"     )] public StringID name;
		[Serialize("activate" )] public bool activate;
		[Serialize("busParams")] public Placeholder busParams;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(activate));
			SerializeField(s, nameof(busParams));
		}
		public override uint? ClassCRC => 0xA61DB3DB;
	}
}

