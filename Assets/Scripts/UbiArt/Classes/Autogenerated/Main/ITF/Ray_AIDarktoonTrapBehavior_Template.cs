using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonTrapBehavior_Template : TemplateAIBehavior {
		[Serialize("startsHidden"     )] public int startsHidden;
		[Serialize("heightFactor"     )] public float heightFactor;
		[Serialize("attackRate"       )] public float attackRate;
		[Serialize("coolDownDuration" )] public float coolDownDuration;
		[Serialize("returnHitMaxLevel")] public uint returnHitMaxLevel;
		[Serialize("outerShape"       )] public Placeholder outerShape;
		[Serialize("innerShape"       )] public Placeholder innerShape;
		[Serialize("idle"             )] public Placeholder idle;
		[Serialize("attack"           )] public Placeholder attack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startsHidden));
			SerializeField(s, nameof(heightFactor));
			SerializeField(s, nameof(attackRate));
			SerializeField(s, nameof(coolDownDuration));
			SerializeField(s, nameof(returnHitMaxLevel));
			SerializeField(s, nameof(outerShape));
			SerializeField(s, nameof(innerShape));
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(attack));
		}
		public override uint? ClassCRC => 0xED2F49D6;
	}
}

