using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MurphyComponent_Template : ActorComponent_Template {
		[Serialize("touchRadius"        )] public float touchRadius;
		[Serialize("brakeForce"         )] public float brakeForce;
		[Serialize("radius2d"           )] public uint radius2d;
		[Serialize("stimRadius"         )] public float stimRadius;
		[Serialize("stimActivationSpeed")] public float stimActivationSpeed;
		[Serialize("faction"            )] public uint faction;
		[Serialize("uturnTimer"         )] public float uturnTimer;
		[Serialize("flyTimer"           )] public float flyTimer;
		[Serialize("idleTimer"          )] public float idleTimer;
		[Serialize("idleSpeedThreshold" )] public float idleSpeedThreshold;
		[Serialize("flySpeedThreshold"  )] public float flySpeedThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(touchRadius));
			SerializeField(s, nameof(brakeForce));
			SerializeField(s, nameof(radius2d));
			SerializeField(s, nameof(stimRadius));
			SerializeField(s, nameof(stimActivationSpeed));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(uturnTimer));
			SerializeField(s, nameof(flyTimer));
			SerializeField(s, nameof(idleTimer));
			SerializeField(s, nameof(idleSpeedThreshold));
			SerializeField(s, nameof(flySpeedThreshold));
		}
		public override uint? ClassCRC => 0x3761096A;
	}
}

