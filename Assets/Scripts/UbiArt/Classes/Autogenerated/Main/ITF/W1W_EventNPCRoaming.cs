using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventNPCRoaming : Event {
		public bool bool__0;
		public bool bool__1;
		public StringID StringID__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
		}
		public override uint? ClassCRC => 0x7118B8E4;
	}
}

