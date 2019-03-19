using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_InteractiveGenComponent_Template : ActorComponent_Template {
		[Serialize("PhysShapePolygon__0")] public PhysShapePolygon PhysShapePolygon__0;
		[Serialize("StringID__1"        )] public StringID StringID__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(PhysShapePolygon__0));
			SerializeField(s, nameof(StringID__1));
		}
		public override uint? ClassCRC => 0x2CC3E8A4;
	}
}

