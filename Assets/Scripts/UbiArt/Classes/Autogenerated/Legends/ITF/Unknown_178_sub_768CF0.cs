using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_178_sub_768CF0 : CSerializable {
		[Serialize("tag")] public StringID tag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tag));
		}
		public override uint? ClassCRC => 0xA10B8681;
	}
}

