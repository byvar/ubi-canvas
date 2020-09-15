using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.RL)]
	public partial class Ray_VacuumData_Template : CSerializable {
		public bool canBeVacuumed;
		public float vacuumMinDuration;
		public float vacuumMaxDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			canBeVacuumed = s.Serialize<bool>(canBeVacuumed, name: "canBeVacuumed");
			vacuumMinDuration = s.Serialize<float>(vacuumMinDuration, name: "vacuumMinDuration");
			vacuumMaxDuration = s.Serialize<float>(vacuumMaxDuration, name: "vacuumMaxDuration");
		}
	}
}

