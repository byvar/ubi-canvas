using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIAlInfernoStaticBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("idle"             )] public Placeholder idle;
		[Serialize("uturn"            )] public Placeholder uturn;
		[Serialize("attack"           )] public Placeholder attack;
		[Serialize("cycleUturn"       )] public Placeholder cycleUturn;
		[Serialize("idleTime"         )] public float idleTime;
		[Serialize("detectionRange"   )] public Placeholder detectionRange;
		[Serialize("attackOnDetection")] public bool attackOnDetection;
		[Serialize("stickOnWalls"     )] public bool stickOnWalls;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(uturn));
			SerializeField(s, nameof(attack));
			SerializeField(s, nameof(cycleUturn));
			SerializeField(s, nameof(idleTime));
			SerializeField(s, nameof(detectionRange));
			SerializeField(s, nameof(attackOnDetection));
			SerializeField(s, nameof(stickOnWalls));
		}
		public override uint? ClassCRC => 0x0B61346E;
	}
}

