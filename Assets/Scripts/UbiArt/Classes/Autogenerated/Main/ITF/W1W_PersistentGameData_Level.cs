using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_PersistentGameData_Level : PersistentGameData_Level {
		[Serialize("uint__0"            )] public uint uint__0;
		[Serialize("uint__1"            )] public uint uint__1;
		[Serialize("bool__2"            )] public bool bool__2;
		[Serialize("bool__3"            )] public bool bool__3;
		[Serialize("uint__4"            )] public uint uint__4;
		[Serialize("CArray<WikiItem>__5")] public CArray<WikiItem> CArray_WikiItem__5;
		[Serialize("CArray<WikiItem>__6")] public CArray<WikiItem> CArray_WikiItem__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(uint__4));
			SerializeField(s, nameof(CArray_WikiItem__5));
			SerializeField(s, nameof(CArray_WikiItem__6));
		}
		public override uint? ClassCRC => 0xFB573729;
	}
}

