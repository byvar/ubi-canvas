namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossLuchadoreHandComponent : GraphicComponent {
		public Generic<PhysShape> hitShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hitShape = s.SerializeObject<Generic<PhysShape>>(hitShape, name: "hitShape");
		}
		public override uint? ClassCRC => 0xF9A91B67;
	}
}

