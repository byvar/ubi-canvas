using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class CamModifierOverride_Template : CSerializable {
		[Serialize("int__0")] public int int__0;
		[Serialize("int__1")] public int int__1;
		[Serialize("int__2")] public int int__2;
		[Serialize("int__3")] public int int__3;
		[Serialize("int__4")] public int int__4;
		[Serialize("int__5")] public int int__5;
		[Serialize("int__6")] public int int__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(int__0));
			SerializeField(s, nameof(int__1));
			SerializeField(s, nameof(int__2));
			SerializeField(s, nameof(int__3));
			SerializeField(s, nameof(int__4));
			SerializeField(s, nameof(int__5));
			SerializeField(s, nameof(int__6));
		}
	}
}

