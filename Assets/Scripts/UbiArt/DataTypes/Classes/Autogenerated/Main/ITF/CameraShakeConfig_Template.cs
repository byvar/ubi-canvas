namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class CameraShakeConfig_Template : TemplateObj {
		public CListO<CameraShake> shakes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
			} else {
				shakes = s.SerializeObject<CListO<CameraShake>>(shakes, name: "shakes");
			}
		}
		public override uint? ClassCRC => 0x04623994;
	}
}

