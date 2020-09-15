using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_InteractiveGenComponent_Template : ActorComponent_Template {
		public PhysShapePolygon PhysShapePolygon__0;
		public StringID StringID__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			PhysShapePolygon__0 = s.SerializeObject<PhysShapePolygon>(PhysShapePolygon__0, name: "PhysShapePolygon__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
		}
		public override uint? ClassCRC => 0x2CC3E8A4;
	}
}

