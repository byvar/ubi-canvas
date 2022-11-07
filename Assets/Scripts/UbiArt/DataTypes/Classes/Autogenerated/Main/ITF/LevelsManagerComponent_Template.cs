namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class LevelsManagerComponent_Template : CSerializable {
		public Generic<PhysShapePolygon> Generic_PhysShapePolygon__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Generic_PhysShapePolygon__0 = s.SerializeObject<Generic<PhysShapePolygon>>(Generic_PhysShapePolygon__0, name: "Generic<PhysShapePolygon>__0");
		}
		public override uint? ClassCRC => 0x3E67A12E;
	}
}

