namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PointOfInterestComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
		}
		public override uint? ClassCRC => 0xF96EF7DD;
	}
}

