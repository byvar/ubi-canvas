using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.RL)]
	public partial class Ray_VacuumData_Template : CSerializable {
		[Serialize("canBeVacuumed"    )] public bool canBeVacuumed;
		[Serialize("vacuumMinDuration")] public float vacuumMinDuration;
		[Serialize("vacuumMaxDuration")] public float vacuumMaxDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(canBeVacuumed));
			SerializeField(s, nameof(vacuumMinDuration));
			SerializeField(s, nameof(vacuumMaxDuration));
		}
	}
}

