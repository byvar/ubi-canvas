namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_UITutorialComponent_Template : UIComponent_Template {
		public Vec2d Vector2__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Vector2__0 = s.SerializeObject<Vec2d>(Vector2__0, name: "Vector2__0");
		}
		public override uint? ClassCRC => 0xB2C014BC;
	}
}

