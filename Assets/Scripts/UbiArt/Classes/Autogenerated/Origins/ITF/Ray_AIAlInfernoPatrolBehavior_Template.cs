using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIAlInfernoPatrolBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		[Serialize("fall"          )] public Placeholder fall;
		[Serialize("defaultPause"  )] public Placeholder defaultPause;
		[Serialize("attack"        )] public Placeholder attack;
		[Serialize("uturnDelay2"   )] public float uturnDelay2;
		[Serialize("detectionRange")] public Placeholder detectionRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fall));
			SerializeField(s, nameof(defaultPause));
			SerializeField(s, nameof(attack));
			SerializeField(s, nameof(uturnDelay2));
			SerializeField(s, nameof(detectionRange));
		}
		public override uint? ClassCRC => 0x2CE9AE3F;
	}
}

