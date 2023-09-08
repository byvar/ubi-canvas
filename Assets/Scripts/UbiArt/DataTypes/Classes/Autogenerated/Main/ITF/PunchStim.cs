namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class PunchStim : HitStim {
		public RECEIVEDHITTYPE hitType;
		public float pushBackDistance;
		public bool radial;
		public float bounceMultiplier;
		public uint identifier;
		public bool hitEnemiesOnce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				hitType = s.Serialize<RECEIVEDHITTYPE>(hitType, name: "hitType");
				pushBackDistance = s.Serialize<float>(pushBackDistance, name: "pushBackDistance");
				radial = s.Serialize<bool>(radial, name: "radial");
				bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
			} else {
				hitType = s.Serialize<RECEIVEDHITTYPE>(hitType, name: "hitType");
				pushBackDistance = s.Serialize<float>(pushBackDistance, name: "pushBackDistance");
				radial = s.Serialize<bool>(radial, name: "radial");
				bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
				identifier = s.Serialize<uint>(identifier, name: "identifier");
				hitEnemiesOnce = s.Serialize<bool>(hitEnemiesOnce, name: "hitEnemiesOnce");
			}
		}
		public enum RECEIVEDHITTYPE {
			[Serialize("RECEIVEDHITTYPE_UNKNOWN"    )] UNKNOWN = -1,
			[Serialize("RECEIVEDHITTYPE_FRONTPUNCH" )] FRONTPUNCH = 0,
			[Serialize("RECEIVEDHITTYPE_UPPUNCH"    )] UPPUNCH = 1,
			[Serialize("RECEIVEDHITTYPE_EJECTXY"    )] EJECTXY = 3,
			[Serialize("RECEIVEDHITTYPE_HURTBOUNCE" )] HURTBOUNCE = 4,
			[Serialize("RECEIVEDHITTYPE_DARKTOONIFY")] DARKTOONIFY = 5,
			[Serialize("RECEIVEDHITTYPE_EARTHQUAKE" )] EARTHQUAKE = 6,
			[Serialize("RECEIVEDHITTYPE_SHOOTER"    )] SHOOTER = 7,
		}
		public override uint? ClassCRC => 0x0BF3E60F;
	}
}

