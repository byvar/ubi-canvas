using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class LevelsManagerComponent_Template : CSerializable {
		[Serialize("Generic<PhysShapePolygon>__0")] public Generic<PhysShapePolygon> Generic_PhysShapePolygon__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Generic_PhysShapePolygon__0));
		}
		public override uint? ClassCRC => 0x3E67A12E;
	}
}

