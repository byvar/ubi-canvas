using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AILivingStoneRoamBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		[Serialize("fall"        )] public Generic<AIFallAction_Template> fall;
		[Serialize("defaultPause")] public Generic<AIAction_Template> defaultPause;
		[Serialize("attack"      )] public Generic<AIAction_Template> attack;
		[Serialize("uturnDelay2" )] public float uturnDelay2;
		[Serialize("attackRange" )] public AABB attackRange;
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

