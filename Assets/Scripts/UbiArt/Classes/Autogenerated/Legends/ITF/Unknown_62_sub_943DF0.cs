using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_62_sub_943DF0 : CSerializable {
		[Serialize("pauseInsensitiveFlags")] public uint pauseInsensitiveFlags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pauseInsensitiveFlags));
		}
		public override uint? ClassCRC => 0xFE2667F1;
	}
}

