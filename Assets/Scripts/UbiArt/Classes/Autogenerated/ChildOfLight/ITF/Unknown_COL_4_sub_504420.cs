using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_4_sub_504420 : CSerializable {
		[Serialize("textureActionMessageBackground"        )] public Path textureActionMessageBackground;
		[Serialize("textureActionMessageBackgroundMaterial")] public Placeholder textureActionMessageBackgroundMaterial;
		[Serialize("textBoxToSpawnPathDamage"              )] public Path textBoxToSpawnPathDamage;
		[Serialize("textBoxToSpawnPathHealCentered"        )] public Path textBoxToSpawnPathHealCentered;
		[Serialize("textBoxToSpawnPathHealOffsetted"       )] public Path textBoxToSpawnPathHealOffsetted;
		[Serialize("textBoxToSpawnPathManaCentered"        )] public Path textBoxToSpawnPathManaCentered;
		[Serialize("textBoxToSpawnPathManaOffsetted"       )] public Path textBoxToSpawnPathManaOffsetted;
		[Serialize("textBoxToSpawnPathRegenHeal"           )] public Path textBoxToSpawnPathRegenHeal;
		[Serialize("textBoxToSpawnPathDodgeAlly"           )] public Path textBoxToSpawnPathDodgeAlly;
		[Serialize("textBoxToSpawnPathDodgeEnemy"          )] public Path textBoxToSpawnPathDodgeEnemy;
		[Serialize("textBoxToSpawnPathInstantKill"         )] public Path textBoxToSpawnPathInstantKill;
		[Serialize("textBoxToSpawnPathPrimaryEffectAlly"   )] public Path textBoxToSpawnPathPrimaryEffectAlly;
		[Serialize("textBoxToSpawnPathPrimaryEffectEnemy"  )] public Path textBoxToSpawnPathPrimaryEffectEnemy;
		[Serialize("textBoxToSpawnPathSecondaryEffectAlly" )] public Path textBoxToSpawnPathSecondaryEffectAlly;
		[Serialize("textBoxToSpawnPathSecondaryEffectEnemy")] public Path textBoxToSpawnPathSecondaryEffectEnemy;
		[Serialize("textBoxToSpawnPathCounterAttackAlly"   )] public Path textBoxToSpawnPathCounterAttackAlly;
		[Serialize("textBoxToSpawnPathCounterAttackEnemy"  )] public Path textBoxToSpawnPathCounterAttackEnemy;
		[Serialize("actionMessageDuration"                 )] public float actionMessageDuration;
		[Serialize("initiativeMessageDuration"             )] public float initiativeMessageDuration;
		[Serialize("initiativeWithSkipIntroMessageDuration")] public float initiativeWithSkipIntroMessageDuration;
		[Serialize("placeAlliesTextBoxAboveHead"           )] public bool placeAlliesTextBoxAboveHead;
		[Serialize("placeEnemyTextBoxAboveHead"            )] public bool placeEnemyTextBoxAboveHead;
		[Serialize("alliesTextBoxVerticalOffset"           )] public float alliesTextBoxVerticalOffset;
		[Serialize("enemyTextBoxVerticalOffset"            )] public float enemyTextBoxVerticalOffset;
		[Serialize("overlapPosOffset"                      )] public float overlapPosOffset;
		[Serialize("overlapTimeOffset"                     )] public float overlapTimeOffset;
		[Serialize("secondaryOverlapPosOffset"             )] public float secondaryOverlapPosOffset;
		[Serialize("secondaryOverlapTimeOffset"            )] public float secondaryOverlapTimeOffset;
		[Serialize("doubleFirstMessageOverlapPosOffset"    )] public float doubleFirstMessageOverlapPosOffset;
		[Serialize("doubleFirstMessageOverlapTimeOffset"   )] public float doubleFirstMessageOverlapTimeOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(textureActionMessageBackground));
			}
			SerializeField(s, nameof(textureActionMessageBackgroundMaterial));
			SerializeField(s, nameof(textBoxToSpawnPathDamage));
			SerializeField(s, nameof(textBoxToSpawnPathHealCentered));
			SerializeField(s, nameof(textBoxToSpawnPathHealOffsetted));
			SerializeField(s, nameof(textBoxToSpawnPathManaCentered));
			SerializeField(s, nameof(textBoxToSpawnPathManaOffsetted));
			SerializeField(s, nameof(textBoxToSpawnPathRegenHeal));
			SerializeField(s, nameof(textBoxToSpawnPathDodgeAlly));
			SerializeField(s, nameof(textBoxToSpawnPathDodgeEnemy));
			SerializeField(s, nameof(textBoxToSpawnPathInstantKill));
			SerializeField(s, nameof(textBoxToSpawnPathPrimaryEffectAlly));
			SerializeField(s, nameof(textBoxToSpawnPathPrimaryEffectEnemy));
			SerializeField(s, nameof(textBoxToSpawnPathSecondaryEffectAlly));
			SerializeField(s, nameof(textBoxToSpawnPathSecondaryEffectEnemy));
			SerializeField(s, nameof(textBoxToSpawnPathCounterAttackAlly));
			SerializeField(s, nameof(textBoxToSpawnPathCounterAttackEnemy));
			SerializeField(s, nameof(actionMessageDuration));
			SerializeField(s, nameof(initiativeMessageDuration));
			SerializeField(s, nameof(initiativeWithSkipIntroMessageDuration));
			SerializeField(s, nameof(placeAlliesTextBoxAboveHead), boolAsByte: true);
			SerializeField(s, nameof(placeEnemyTextBoxAboveHead), boolAsByte: true);
			SerializeField(s, nameof(alliesTextBoxVerticalOffset));
			SerializeField(s, nameof(enemyTextBoxVerticalOffset));
			SerializeField(s, nameof(overlapPosOffset));
			SerializeField(s, nameof(overlapTimeOffset));
			SerializeField(s, nameof(secondaryOverlapPosOffset));
			SerializeField(s, nameof(secondaryOverlapTimeOffset));
			SerializeField(s, nameof(doubleFirstMessageOverlapPosOffset));
			SerializeField(s, nameof(doubleFirstMessageOverlapTimeOffset));
		}
		public override uint? ClassCRC => 0x79FD7E95;
	}
}

