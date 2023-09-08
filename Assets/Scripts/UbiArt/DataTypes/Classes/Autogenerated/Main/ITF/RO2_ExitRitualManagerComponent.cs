namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ExitRitualManagerComponent : ActorComponent {
		public RitualType ritualType;
		public bool canBeClosed = true;
		public bool canDisplayTuto = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					ritualType = s.Serialize<RitualType>(ritualType, name: "ritualType");
					canBeClosed = s.Serialize<bool>(canBeClosed, name: "canBeClosed", options: CSerializerObject.Options.BoolAsByte);
					canDisplayTuto = s.Serialize<bool>(canDisplayTuto, name: "canDisplayTuto", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					ritualType = s.Serialize<RitualType>(ritualType, name: "ritualType");
					canBeClosed = s.Serialize<bool>(canBeClosed, name: "canBeClosed");
					canDisplayTuto = s.Serialize<bool>(canDisplayTuto, name: "canDisplayTuto");
				}
			}
		}
		public enum RitualType {
			[Serialize("RitualType_Ground")] Ground = 0,
			[Serialize("RitualType_Air"   )] Air = 1,
		}
		public override uint? ClassCRC => 0x3544D1A6;
	}
}

