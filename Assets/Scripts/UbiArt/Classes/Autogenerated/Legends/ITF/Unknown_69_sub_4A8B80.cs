using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_69_sub_4A8B80 : CSerializable {
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
		}
		public override uint? ClassCRC => 0xAACFE19E;
	}
}

