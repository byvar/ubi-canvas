using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PolygonWindComponent : CSerializable {
		public Placeholder point;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			point = s.SerializeObject<Placeholder>(point, name: "point");
		}
		public override uint? ClassCRC => 0xEEC96D29;
	}
}

