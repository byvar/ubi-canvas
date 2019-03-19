using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AISwordFishBehavior_Template : RO2_AIGroundBaseBehavior_Template {
		[Serialize("idle"                )] public Generic<AIAction_Template> idle;
		[Serialize("anticipation"        )] public Generic<AIAction_Template> anticipation;
		[Serialize("attack"              )] public Generic<AIAction_Template> attack;
		[Serialize("stuck"               )] public Generic<AIAction_Template> stuck;
		[Serialize("detectionShape"      )] public Generic<PhysShape> detectionShape;
		[Serialize("anticipationDuration")] public float anticipationDuration;
		[Serialize("force"               )] public float force;
		[Serialize("maxSpeed"            )] public float maxSpeed;
		[Serialize("minSpeed"            )] public float minSpeed;
		[Serialize("offsetDist"          )] public float offsetDist;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(anticipation));
			SerializeField(s, nameof(attack));
			SerializeField(s, nameof(stuck));
			SerializeField(s, nameof(detectionShape));
			SerializeField(s, nameof(anticipationDuration));
			SerializeField(s, nameof(force));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(minSpeed));
			SerializeField(s, nameof(offsetDist));
		}
		public override uint? ClassCRC => 0xA9185A9A;
	}
}

