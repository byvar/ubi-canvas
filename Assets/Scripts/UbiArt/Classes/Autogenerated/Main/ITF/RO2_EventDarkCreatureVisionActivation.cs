using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventDarkCreatureVisionActivation : Event {
		public float DetectionDistance;
		public float AttackDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DetectionDistance = s.Serialize<float>(DetectionDistance, name: "DetectionDistance");
			AttackDistance = s.Serialize<float>(AttackDistance, name: "AttackDistance");
		}
		public override uint? ClassCRC => 0xE63E044A;
	}
}

