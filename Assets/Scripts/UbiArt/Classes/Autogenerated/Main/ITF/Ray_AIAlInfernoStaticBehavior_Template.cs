using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIAlInfernoStaticBehavior_Template : TemplateAIBehavior {
		[Serialize("idle"             )] public Generic<AIAction_Template> idle;
		[Serialize("uturn"            )] public Generic<AIAction_Template> uturn;
		[Serialize("attack"           )] public Generic<AIAction_Template> attack;
		[Serialize("cycleUturn"       )] public Generic<AIAction_Template> cycleUturn;
		[Serialize("idleTime"         )] public float idleTime;
		[Serialize("detectionRange"   )] public AABB detectionRange;
		[Serialize("attackOnDetection")] public int attackOnDetection;
		[Serialize("stickOnWalls"     )] public int stickOnWalls;
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

