namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TouchScreenInputComponent : ShapeComponent {
		public string viewName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RA || s.Settings.Game == Game.RM || s.Settings.Platform == GamePlatform.Vita) {
				viewName = s.Serialize<string>(viewName, name: "viewName");
			}
		}
		public override uint? ClassCRC => 0x8F11DEDF;
	}
}

