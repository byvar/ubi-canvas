using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_MailboxElementLight : CSerializable {
		public string uniqueId;
		public Enum_type type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uniqueId = s.Serialize<string>(uniqueId, name: "uniqueId");
			type = s.Serialize<Enum_type>(type, name: "type");
		}
		public enum Enum_type {
			[Serialize("MESSAGE")] MESSAGE = 0,
			[Serialize("NEWS"   )] NEWS = 1,
			[Serialize("FRIEND" )] FRIEND = 2,
		}
	}
}

