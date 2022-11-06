using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventSetBindChilds : Event {
		public StringID StringID__0;
		public bool bool__1;
		public bool bool__2;
		public bool bool__3;
		public bool bool__4;
		public bool bool__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			bool__4 = s.Serialize<bool>(bool__4, name: "bool__4");
			bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
		}
		public override uint? ClassCRC => 0xFD48BE51;
	}
}

