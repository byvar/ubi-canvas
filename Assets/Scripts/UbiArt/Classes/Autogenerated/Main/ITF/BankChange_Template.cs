using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class BankChange_Template : CSerializable {
		[Serialize("friendlyName")] public StringID friendlyName;
		[Serialize("bankName"    )] public StringID bankName;
		[Serialize("bankPath"    )] public Path bankPath;
		[Serialize("state"       )] public uint state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(friendlyName));
			SerializeField(s, nameof(bankName));
			SerializeField(s, nameof(bankPath));
			SerializeField(s, nameof(state));
		}
	}
}

