using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AILivingStoneRoamBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		[Serialize("fall"        )] public Placeholder fall;
		[Serialize("defaultPause")] public Placeholder defaultPause;
		[Serialize("attack"      )] public Placeholder attack;
		[Serialize("uturnDelay2" )] public float uturnDelay2;
		[Serialize("attackRange" )] public Placeholder attackRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fall));
			SerializeField(s, nameof(defaultPause));
			SerializeField(s, nameof(attack));
			SerializeField(s, nameof(uturnDelay2));
			SerializeField(s, nameof(attackRange));
		}
		public override uint? ClassCRC => 0x7F91F03C;
	}
}

