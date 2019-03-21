using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ExitRitualManagerComponent : ActorComponent {
		[Serialize("ritualType"    )] public RitualType ritualType;
		[Serialize("canBeClosed"   )] public bool canBeClosed;
		[Serialize("canDisplayTuto")] public bool canDisplayTuto;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(ritualType));
					SerializeField(s, nameof(canBeClosed), boolAsByte: true);
					SerializeField(s, nameof(canDisplayTuto), boolAsByte: true);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(ritualType));
					SerializeField(s, nameof(canBeClosed));
					SerializeField(s, nameof(canDisplayTuto));
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

