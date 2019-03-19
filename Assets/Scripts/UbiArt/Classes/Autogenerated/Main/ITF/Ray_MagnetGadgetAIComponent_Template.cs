using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_MagnetGadgetAIComponent_Template : CSerializable {
		[Serialize("float__0")] public float float__0;
		[Serialize("float__1")] public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(float__1));
		}
		public override uint? ClassCRC => 0x720F1A7A;
	}
}

