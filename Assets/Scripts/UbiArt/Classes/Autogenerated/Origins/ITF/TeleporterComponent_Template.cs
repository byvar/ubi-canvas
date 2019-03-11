using UnityEngine;

namespace UbiArt.ITF {
	public partial class TeleporterComponent_Template : CSerializable {
		[Serialize("INDEX")] public uint INDEX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(INDEX));
		}
		public override uint? ClassCRC => 0x68E28639;
	}
}

