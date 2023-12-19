namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_ButtonComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> Generic_PhysShape__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Generic_PhysShape__0 = s.SerializeObject<Generic<PhysShape>>(Generic_PhysShape__0, name: "Generic<PhysShape>__0");
		}
		public override uint? ClassCRC => 0xAE32DDF6;
	}
}

