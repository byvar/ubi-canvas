namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class DummyComponent : ActorComponent {
		public bool is2D;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RA || s.Settings.Game == Game.RM) {
				is2D = s.Serialize<bool>(is2D, name: "is2D");
			}
		}
		public override uint? ClassCRC => 0xB0493A6E;
	}
}

