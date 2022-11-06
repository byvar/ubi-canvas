using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_PersistentGameData_Level : PersistentGameData_Level {
		public uint uint__0;
		public uint uint__1;
		public bool bool__2;
		public bool bool__3;
		public uint uint__4;
		public CArrayO<WikiItem> CArray_WikiItem__5;
		public CArrayO<WikiItem> CArray_WikiItem__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
			CArray_WikiItem__5 = s.SerializeObject<CArrayO<WikiItem>>(CArray_WikiItem__5, name: "CArray<WikiItem>__5");
			CArray_WikiItem__6 = s.SerializeObject<CArrayO<WikiItem>>(CArray_WikiItem__6, name: "CArray<WikiItem>__6");
		}
		public override uint? ClassCRC => 0xFB573729;
	}
}

