namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class TweenSine_Template : TweenTranslation_Template {
		public Vec3d movement;
		public float amplitude = 1f;
		public float cycleCount = 1f;
		public float cycleOffset;
		public bool CosinusOnX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				movement = s.SerializeObject<Vec3d>(movement, name: "movement");
				amplitude = s.Serialize<float>(amplitude, name: "amplitude");
				cycleCount = s.Serialize<float>(cycleCount, name: "cycleCount");
				cycleOffset = s.Serialize<float>(cycleOffset, name: "cycleOffset");
			} else {
				movement = s.SerializeObject<Vec3d>(movement, name: "movement");
				amplitude = s.Serialize<float>(amplitude, name: "amplitude");
				cycleCount = s.Serialize<float>(cycleCount, name: "cycleCount");
				cycleOffset = s.Serialize<float>(cycleOffset, name: "cycleOffset");
				CosinusOnX = s.Serialize<bool>(CosinusOnX, name: "CosinusOnX");
			}
		}
		public override uint? ClassCRC => 0x2D3E7D44;
	}
}

