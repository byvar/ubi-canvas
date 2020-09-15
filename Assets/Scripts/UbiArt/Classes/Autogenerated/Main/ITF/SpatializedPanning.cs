using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class SpatializedPanning : SoundModifier {
		public float widthMin;
		public float widthMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			widthMin = s.Serialize<float>(widthMin, name: "widthMin");
			widthMax = s.Serialize<float>(widthMax, name: "widthMax");
		}
		public override uint? ClassCRC => 0x6922689D;
	}
}

