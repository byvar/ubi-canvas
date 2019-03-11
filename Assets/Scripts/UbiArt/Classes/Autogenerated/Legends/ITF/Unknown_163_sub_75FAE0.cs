using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_163_sub_75FAE0 : CSerializable {
		[Serialize("type" )] public StringID type;
		[Serialize("value")] public bool value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(value));
		}
		public override uint? ClassCRC => 0x047CADF9;
	}
}

