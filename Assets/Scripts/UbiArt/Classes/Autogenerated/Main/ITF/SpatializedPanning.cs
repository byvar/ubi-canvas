using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class SpatializedPanning : CSerializable {
		[Serialize("widthMin")] public float widthMin;
		[Serialize("widthMax")] public float widthMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(widthMin));
			SerializeField(s, nameof(widthMax));
		}
		public override uint? ClassCRC => 0x6922689D;
	}
}

