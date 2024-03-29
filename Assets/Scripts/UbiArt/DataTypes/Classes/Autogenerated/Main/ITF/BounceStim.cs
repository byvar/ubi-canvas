namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RL | GameFlags.RAVersion)]
	public partial class BounceStim : EventStim {
		public BOUNCETYPE bounceType;
		public Vec2d direction;
		public bool radial;
		public float multiplier;
		public uint bounceReactType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				bounceType = s.Serialize<BOUNCETYPE>(bounceType, name: "bounceType");
				bounceReactType = s.Serialize<uint>(bounceReactType, name: "bounceReactType");
				direction = s.SerializeObject<Vec2d>(direction, name: "direction");
				radial = s.Serialize<bool>(radial, name: "radial");
				multiplier = s.Serialize<float>(multiplier, name: "multiplier");
			} else {
				bounceType = s.Serialize<BOUNCETYPE>(bounceType, name: "bounceType");
				direction = s.SerializeObject<Vec2d>(direction, name: "direction");
				radial = s.Serialize<bool>(radial, name: "radial");
				multiplier = s.Serialize<float>(multiplier, name: "multiplier");
			}
		}
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_ENEMY"            )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER"           )] BUMPER = 2,
			[Serialize("BOUNCETYPE_BUMPER_AIRCONTROL")] BUMPER_AIRCONTROL = 8,
			[Serialize("BOUNCETYPE_SETBACKS"         )] SETBACKS = 7,
		}
		public override uint? ClassCRC => 0x30DD3B8D;
	}
}

