using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class BankChange_Template : CSerializable {
		public StringID friendlyName;
		public StringID bankName;
		public Path bankPath;
		public uint state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			friendlyName = s.SerializeObject<StringID>(friendlyName, name: "friendlyName");
			bankName = s.SerializeObject<StringID>(bankName, name: "bankName");
			bankPath = s.SerializeObject<Path>(bankPath, name: "bankPath");
			state = s.Serialize<uint>(state, name: "state");
		}
	}
}

