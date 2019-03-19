using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PolygonWindComponent : CSerializable {
		[Serialize("point")] public Placeholder point;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(point));
		}
		public override uint? ClassCRC => 0xEEC96D29;
	}
}

