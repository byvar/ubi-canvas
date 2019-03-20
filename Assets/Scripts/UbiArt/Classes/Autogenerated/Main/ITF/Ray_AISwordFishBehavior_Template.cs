using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AISwordFishBehavior_Template : TemplateAIBehavior {
		[Serialize("idle"                )] public Placeholder idle;
		[Serialize("anticipation"        )] public Placeholder anticipation;
		[Serialize("attack"              )] public Placeholder attack;
		[Serialize("stuck"               )] public Placeholder stuck;
		[Serialize("detectionShape"      )] public Placeholder detectionShape;
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
		public override uint? ClassCRC => 0xE0DE0498;
	}
}

