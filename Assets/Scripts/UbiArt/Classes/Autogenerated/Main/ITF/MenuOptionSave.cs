using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class MenuOptionSave : CSerializable {
		[Serialize("bool__0"  )] public bool bool__0;
		[Serialize("bool__1"  )] public bool bool__1;
		[Serialize("bool__2"  )] public bool bool__2;
		[Serialize("bool__3"  )] public bool bool__3;
		[Serialize("uint__4"  )] public uint uint__4;
		[Serialize("uint__5"  )] public uint uint__5;
		[Serialize("string__6")] public string string__6;
		[Serialize("string__7")] public string string__7;
		[Serialize("string__8")] public string string__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(bool__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(uint__4));
			SerializeField(s, nameof(uint__5));
			SerializeField(s, nameof(string__6));
			SerializeField(s, nameof(string__7));
			SerializeField(s, nameof(string__8));
		}
	}
}

