using UnityEngine;

namespace UbiArt.ITF {
	public partial class BodyPart_Template : BodyPartBase_Template {
		[Serialize("actorRenderer" )] public Placeholder actorRenderer;
		[Serialize("spriteRenderer")] public Placeholder spriteRenderer;
		[Serialize("health"        )] public bool health;
		[Serialize("destroyOnDeath")] public bool destroyOnDeath;
		[Serialize("damageLevels"  )] public Placeholder damageLevels;
		[Serialize("leftHitAnim"   )] public StringID leftHitAnim;
		[Serialize("rightHitAnim"  )] public StringID rightHitAnim;
		[Serialize("deathAnim"     )] public StringID deathAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorRenderer));
			SerializeField(s, nameof(spriteRenderer));
			SerializeField(s, nameof(health));
			SerializeField(s, nameof(destroyOnDeath));
			SerializeField(s, nameof(damageLevels));
			SerializeField(s, nameof(leftHitAnim));
			SerializeField(s, nameof(rightHitAnim));
			SerializeField(s, nameof(deathAnim));
		}
		public override uint? ClassCRC => 0xAFE4FD27;
	}
}

