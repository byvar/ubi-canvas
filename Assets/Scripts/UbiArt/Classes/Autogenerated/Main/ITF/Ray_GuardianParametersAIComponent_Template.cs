using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_GuardianParametersAIComponent_Template : CSerializable {
		[Serialize("int__0")] public int int__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(int__0));
		}
		public override uint? ClassCRC => 0xB8760440;
	}
}

