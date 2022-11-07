namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class KeepAliveComponent_Template : ActorComponent_Template {
		public bool startDying;
		public bool useFade;
		public float fadeDuration;
		public int startDying2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				startDying2 = s.Serialize<int>(startDying2, name: "startDying");
			} else {
				startDying = s.Serialize<bool>(startDying, name: "startDying");
				useFade = s.Serialize<bool>(useFade, name: "useFade");
				fadeDuration = s.Serialize<float>(fadeDuration, name: "fadeDuration");
			}
		}
		public override uint? ClassCRC => 0x991810D0;
	}
}

