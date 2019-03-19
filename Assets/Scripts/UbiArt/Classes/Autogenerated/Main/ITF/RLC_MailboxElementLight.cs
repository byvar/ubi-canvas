using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_MailboxElementLight : CSerializable {
		[Serialize("uniqueId")] public string uniqueId;
		[Serialize("type"    )] public Enum_type type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uniqueId));
			SerializeField(s, nameof(type));
		}
		public enum Enum_type {
			[Serialize("MESSAGE")] MESSAGE = 0,
			[Serialize("NEWS"   )] NEWS = 1,
			[Serialize("FRIEND" )] FRIEND = 2,
		}
	}
}

