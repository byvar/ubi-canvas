namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TweenLine_Template : TweenTranslation_Template {
		public Vec3d movement;
		public bool CosinusOnX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				movement = s.SerializeObject<Vec3d>(movement, name: "movement");
			} else {
				movement = s.SerializeObject<Vec3d>(movement, name: "movement");
				CosinusOnX = s.Serialize<bool>(CosinusOnX, name: "CosinusOnX");
			}
		}
		public override uint? ClassCRC => 0x6A97A07E;
	}
}

