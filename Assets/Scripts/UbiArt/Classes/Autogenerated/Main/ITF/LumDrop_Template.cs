using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class LumDrop_Template : CSerializable {
		[Serialize("float__0")] public float float__0;
		[Serialize("Angle__1")] public Angle Angle__1;
		[Serialize("float__2")] public float float__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(Angle__1));
			SerializeField(s, nameof(float__2));
		}
	}
}

