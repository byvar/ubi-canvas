namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class HitStim : EventStim {
		public uint level;
		public Vec2d direction;
		public uint faction = uint.MaxValue;
		public Vec3d fxPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				level = s.Serialize<uint>(level, name: "level");
				direction = s.SerializeObject<Vec2d>(direction, name: "direction");
				faction = s.Serialize<uint>(faction, name: "faction");
			} else {
				level = s.Serialize<uint>(level, name: "level");
				direction = s.SerializeObject<Vec2d>(direction, name: "direction");
				faction = s.Serialize<uint>(faction, name: "faction");
				fxPos = s.SerializeObject<Vec3d>(fxPos, name: "fxPos");
			}
		}
		public override uint? ClassCRC => 0x7E76FF34;
	}
}

