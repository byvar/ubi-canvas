namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimatedComponent : AnimLightComponent {
		public bool DebugAnimTransition;
		public CArrayO<Generic<Event>> EventPostComponents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO || s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RL || s.Settings.Game == Game.COL || s.Settings.Game == Game.VH) {
			} else {
				DebugAnimTransition = s.Serialize<bool>(DebugAnimTransition, name: "DebugAnimTransition");
				EventPostComponents = s.SerializeObject<CArrayO<Generic<Event>>>(EventPostComponents, name: "EventPostComponents");
			}
		}
		public override uint? ClassCRC => 0x62A12110;
	}
}

