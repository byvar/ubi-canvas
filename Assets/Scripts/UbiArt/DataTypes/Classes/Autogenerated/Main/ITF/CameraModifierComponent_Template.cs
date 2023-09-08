namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class CameraModifierComponent_Template : ActorComponent_Template {
		public CamModifier_Template CM;
		public Vec2d SCALE = new Vec2d(32.4f, 18.225f);
		public CamModifierOverride_Template CM_override;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RJR) {
				CM = s.SerializeObject<CamModifier_Template>(CM, name: "CM");
				CM_override = s.SerializeObject<CamModifierOverride_Template>(CM_override, name: "CM_override");
			} else {
				CM = s.SerializeObject<CamModifier_Template>(CM, name: "CM");
				SCALE = s.SerializeObject<Vec2d>(SCALE, name: "SCALE");
			}
		}
		public override uint? ClassCRC => 0xDCA22B54;
	}
}

