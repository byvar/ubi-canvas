using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class CamModifierOverride : CSerializable {
		[Serialize("int__0")] public int int__0;
		[Serialize("int__1")] public int int__1;
		[Serialize("int__2")] public int int__2;
		[Serialize("int__3")] public int int__3;
		[Serialize("int__4")] public int int__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(int__0));
				SerializeField(s, nameof(int__1));
				SerializeField(s, nameof(int__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(int__4));
			}
		}
	}
}

