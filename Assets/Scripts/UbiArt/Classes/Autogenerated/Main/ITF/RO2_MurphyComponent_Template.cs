using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MurphyComponent_Template : ActorComponent_Template {
		public float touchRadius;
		public float brakeForce;
		public uint radius2d;
		public float stimRadius;
		public float stimActivationSpeed;
		public uint faction;
		public float uturnTimer;
		public float flyTimer;
		public float idleTimer;
		public float idleSpeedThreshold;
		public float flySpeedThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			touchRadius = s.Serialize<float>(touchRadius, name: "touchRadius");
			brakeForce = s.Serialize<float>(brakeForce, name: "brakeForce");
			radius2d = s.Serialize<uint>(radius2d, name: "radius2d");
			stimRadius = s.Serialize<float>(stimRadius, name: "stimRadius");
			stimActivationSpeed = s.Serialize<float>(stimActivationSpeed, name: "stimActivationSpeed");
			faction = s.Serialize<uint>(faction, name: "faction");
			uturnTimer = s.Serialize<float>(uturnTimer, name: "uturnTimer");
			flyTimer = s.Serialize<float>(flyTimer, name: "flyTimer");
			idleTimer = s.Serialize<float>(idleTimer, name: "idleTimer");
			idleSpeedThreshold = s.Serialize<float>(idleSpeedThreshold, name: "idleSpeedThreshold");
			flySpeedThreshold = s.Serialize<float>(flySpeedThreshold, name: "flySpeedThreshold");
		}
		public override uint? ClassCRC => 0x3761096A;
	}
}

