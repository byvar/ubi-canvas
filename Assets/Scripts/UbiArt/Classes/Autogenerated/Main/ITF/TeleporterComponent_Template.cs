using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class TeleporterComponent_Template : CSerializable {
		public uint INDEX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			INDEX = s.Serialize<uint>(INDEX, name: "INDEX");
		}
		public override uint? ClassCRC => 0x68E28639;
	}
}

