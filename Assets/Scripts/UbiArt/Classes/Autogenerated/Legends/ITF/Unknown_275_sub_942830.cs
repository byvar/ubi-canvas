using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_275_sub_942830 : CSerializable {
		[Serialize("pauseInsensitiveFlags")] public uint pauseInsensitiveFlags;
		[Serialize("looping"              )] public bool looping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pauseInsensitiveFlags));
			SerializeField(s, nameof(looping));
		}
		public override uint? ClassCRC => 0x0D375BB7;
	}
}

