using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SaveIdentifier : CSerializable {
		public string pid;
		public uint slot;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pid = s.Serialize<string>(pid, name: "pid");
			slot = s.Serialize<uint>(slot, name: "slot");
		}
		public override uint? ClassCRC => 0xCC7AE662;
	}
}

