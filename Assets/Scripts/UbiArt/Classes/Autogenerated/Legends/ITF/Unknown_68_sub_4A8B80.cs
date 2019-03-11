using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_68_sub_4A8B80 : CSerializable {
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
		}
		public override uint? ClassCRC => 0x5F92A481;
	}
}

