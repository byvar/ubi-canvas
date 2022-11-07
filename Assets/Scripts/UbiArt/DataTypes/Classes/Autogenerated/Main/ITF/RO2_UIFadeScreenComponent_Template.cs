namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_UIFadeScreenComponent_Template : UIComponent_Template {
		public CListO<UIFadeEntry> types;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			types = s.SerializeObject<CListO<UIFadeEntry>>(types, name: "types");
			animSize = s.SerializeObject<Vec2d>(animSize, name: "animSize");
		}
		public override uint? ClassCRC => 0xC7834786;
	}
}

