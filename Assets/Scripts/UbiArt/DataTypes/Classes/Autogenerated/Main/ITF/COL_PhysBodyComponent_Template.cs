namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PhysBodyComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> physShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			physShape = s.SerializeObject<Generic<PhysShape>>(physShape, name: "physShape");
		}
		public override uint? ClassCRC => 0xB29157FA;
	}
}

