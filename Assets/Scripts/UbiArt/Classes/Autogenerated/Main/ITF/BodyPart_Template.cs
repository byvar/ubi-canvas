using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class BodyPart_Template : BodyPartBase_Template {
		[Serialize("actorRenderer" )] public BodyPartActorRenderer_Template actorRenderer;
		[Serialize("spriteRenderer")] public BodyPartSpriteRenderer_Template spriteRenderer;
		[Serialize("health"        )] public int health;
		[Serialize("destroyOnDeath")] public int destroyOnDeath;
		[Serialize("damageLevels"  )] public CArray<uint> damageLevels;
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

