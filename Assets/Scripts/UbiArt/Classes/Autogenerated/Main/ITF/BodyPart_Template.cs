using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class BodyPart_Template : BodyPartBase_Template {
		public BodyPartActorRenderer_Template actorRenderer;
		public BodyPartSpriteRenderer_Template spriteRenderer;
		public int health;
		public int destroyOnDeath;
		public CArray<uint> damageLevels;
		public StringID leftHitAnim;
		public StringID rightHitAnim;
		public StringID deathAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actorRenderer = s.SerializeObject<BodyPartActorRenderer_Template>(actorRenderer, name: "actorRenderer");
			spriteRenderer = s.SerializeObject<BodyPartSpriteRenderer_Template>(spriteRenderer, name: "spriteRenderer");
			health = s.Serialize<int>(health, name: "health");
			destroyOnDeath = s.Serialize<int>(destroyOnDeath, name: "destroyOnDeath");
			damageLevels = s.SerializeObject<CArray<uint>>(damageLevels, name: "damageLevels");
			leftHitAnim = s.SerializeObject<StringID>(leftHitAnim, name: "leftHitAnim");
			rightHitAnim = s.SerializeObject<StringID>(rightHitAnim, name: "rightHitAnim");
			deathAnim = s.SerializeObject<StringID>(deathAnim, name: "deathAnim");
		}
		public override uint? ClassCRC => 0xAFE4FD27;
	}
}

