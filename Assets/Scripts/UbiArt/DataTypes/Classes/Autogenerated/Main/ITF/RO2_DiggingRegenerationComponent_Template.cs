namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_DiggingRegenerationComponent_Template : ActorComponent_Template {
		public float RadiusAdditive = 1f;
		public float RadiusRegenerationSafe = 1f;
		public float TruncateRadiusRegenerationSafe = float.MaxValue;
		public Vec2d OffsetRegenerationSafe;
		public float RadiusFillingSafe = 1f;
		public Vec2d OffsetFillingSafe;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				RadiusAdditive = s.Serialize<float>(RadiusAdditive, name: "RadiusAdditive");
			}
			RadiusRegenerationSafe = s.Serialize<float>(RadiusRegenerationSafe, name: "RadiusRegenerationSafe");
			TruncateRadiusRegenerationSafe = s.Serialize<float>(TruncateRadiusRegenerationSafe, name: "TruncateRadiusRegenerationSafe");
			OffsetRegenerationSafe = s.SerializeObject<Vec2d>(OffsetRegenerationSafe, name: "OffsetRegenerationSafe");
			RadiusFillingSafe = s.Serialize<float>(RadiusFillingSafe, name: "RadiusFillingSafe");
			OffsetFillingSafe = s.SerializeObject<Vec2d>(OffsetFillingSafe, name: "OffsetFillingSafe");
		}
		public override uint? ClassCRC => 0xAC5B8709;
	}
}

