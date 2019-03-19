using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class RJR_PowerUp : CSerializable {
		[Serialize("int__0")] public int int__0;
		[Serialize("int__1")] public int int__1;
		[Serialize("int__2")] public int int__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(int__0));
			SerializeField(s, nameof(int__1));
			SerializeField(s, nameof(int__2));
		}
	}
}

