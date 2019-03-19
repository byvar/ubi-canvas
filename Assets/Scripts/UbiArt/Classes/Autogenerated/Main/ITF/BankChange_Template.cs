using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class BankChange_Template : CSerializable {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("StringID__1")] public StringID StringID__1;
		[Serialize("Path__2"    )] public Path Path__2;
		[Serialize("uint__3"    )] public uint uint__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(Path__2));
			SerializeField(s, nameof(uint__3));
		}
	}
}

