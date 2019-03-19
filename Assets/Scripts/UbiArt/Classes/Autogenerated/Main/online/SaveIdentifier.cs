using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SaveIdentifier : CSerializable {
		[Serialize("pid" )] public string pid;
		[Serialize("slot")] public uint slot;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pid));
			SerializeField(s, nameof(slot));
		}
		public override uint? ClassCRC => 0xCC7AE662;
	}
}

