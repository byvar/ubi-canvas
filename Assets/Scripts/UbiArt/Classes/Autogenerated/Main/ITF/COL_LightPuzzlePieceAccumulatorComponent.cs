using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightPuzzlePieceAccumulatorComponent : CSerializable {
		[Description("")]
		public float focusDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			focusDuration = s.Serialize<float>(focusDuration, name: "focusDuration");
		}
		public override uint? ClassCRC => 0xF9ED2023;
	}
}

