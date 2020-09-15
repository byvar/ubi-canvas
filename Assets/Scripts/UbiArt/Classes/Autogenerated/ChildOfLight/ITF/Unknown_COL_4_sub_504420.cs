using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_4_sub_504420 : CSerializable {
		public Path textureActionMessageBackground;
		public Placeholder textureActionMessageBackgroundMaterial;
		public Path textBoxToSpawnPathDamage;
		public Path textBoxToSpawnPathHealCentered;
		public Path textBoxToSpawnPathHealOffsetted;
		public Path textBoxToSpawnPathManaCentered;
		public Path textBoxToSpawnPathManaOffsetted;
		public Path textBoxToSpawnPathRegenHeal;
		public Path textBoxToSpawnPathDodgeAlly;
		public Path textBoxToSpawnPathDodgeEnemy;
		public Path textBoxToSpawnPathInstantKill;
		public Path textBoxToSpawnPathPrimaryEffectAlly;
		public Path textBoxToSpawnPathPrimaryEffectEnemy;
		public Path textBoxToSpawnPathSecondaryEffectAlly;
		public Path textBoxToSpawnPathSecondaryEffectEnemy;
		public Path textBoxToSpawnPathCounterAttackAlly;
		public Path textBoxToSpawnPathCounterAttackEnemy;
		public float actionMessageDuration;
		public float initiativeMessageDuration;
		public float initiativeWithSkipIntroMessageDuration;
		public bool placeAlliesTextBoxAboveHead;
		public bool placeEnemyTextBoxAboveHead;
		public float alliesTextBoxVerticalOffset;
		public float enemyTextBoxVerticalOffset;
		public float overlapPosOffset;
		public float overlapTimeOffset;
		public float secondaryOverlapPosOffset;
		public float secondaryOverlapTimeOffset;
		public float doubleFirstMessageOverlapPosOffset;
		public float doubleFirstMessageOverlapTimeOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				textureActionMessageBackground = s.SerializeObject<Path>(textureActionMessageBackground, name: "textureActionMessageBackground");
			}
			textureActionMessageBackgroundMaterial = s.SerializeObject<Placeholder>(textureActionMessageBackgroundMaterial, name: "textureActionMessageBackgroundMaterial");
			textBoxToSpawnPathDamage = s.SerializeObject<Path>(textBoxToSpawnPathDamage, name: "textBoxToSpawnPathDamage");
			textBoxToSpawnPathHealCentered = s.SerializeObject<Path>(textBoxToSpawnPathHealCentered, name: "textBoxToSpawnPathHealCentered");
			textBoxToSpawnPathHealOffsetted = s.SerializeObject<Path>(textBoxToSpawnPathHealOffsetted, name: "textBoxToSpawnPathHealOffsetted");
			textBoxToSpawnPathManaCentered = s.SerializeObject<Path>(textBoxToSpawnPathManaCentered, name: "textBoxToSpawnPathManaCentered");
			textBoxToSpawnPathManaOffsetted = s.SerializeObject<Path>(textBoxToSpawnPathManaOffsetted, name: "textBoxToSpawnPathManaOffsetted");
			textBoxToSpawnPathRegenHeal = s.SerializeObject<Path>(textBoxToSpawnPathRegenHeal, name: "textBoxToSpawnPathRegenHeal");
			textBoxToSpawnPathDodgeAlly = s.SerializeObject<Path>(textBoxToSpawnPathDodgeAlly, name: "textBoxToSpawnPathDodgeAlly");
			textBoxToSpawnPathDodgeEnemy = s.SerializeObject<Path>(textBoxToSpawnPathDodgeEnemy, name: "textBoxToSpawnPathDodgeEnemy");
			textBoxToSpawnPathInstantKill = s.SerializeObject<Path>(textBoxToSpawnPathInstantKill, name: "textBoxToSpawnPathInstantKill");
			textBoxToSpawnPathPrimaryEffectAlly = s.SerializeObject<Path>(textBoxToSpawnPathPrimaryEffectAlly, name: "textBoxToSpawnPathPrimaryEffectAlly");
			textBoxToSpawnPathPrimaryEffectEnemy = s.SerializeObject<Path>(textBoxToSpawnPathPrimaryEffectEnemy, name: "textBoxToSpawnPathPrimaryEffectEnemy");
			textBoxToSpawnPathSecondaryEffectAlly = s.SerializeObject<Path>(textBoxToSpawnPathSecondaryEffectAlly, name: "textBoxToSpawnPathSecondaryEffectAlly");
			textBoxToSpawnPathSecondaryEffectEnemy = s.SerializeObject<Path>(textBoxToSpawnPathSecondaryEffectEnemy, name: "textBoxToSpawnPathSecondaryEffectEnemy");
			textBoxToSpawnPathCounterAttackAlly = s.SerializeObject<Path>(textBoxToSpawnPathCounterAttackAlly, name: "textBoxToSpawnPathCounterAttackAlly");
			textBoxToSpawnPathCounterAttackEnemy = s.SerializeObject<Path>(textBoxToSpawnPathCounterAttackEnemy, name: "textBoxToSpawnPathCounterAttackEnemy");
			actionMessageDuration = s.Serialize<float>(actionMessageDuration, name: "actionMessageDuration");
			initiativeMessageDuration = s.Serialize<float>(initiativeMessageDuration, name: "initiativeMessageDuration");
			initiativeWithSkipIntroMessageDuration = s.Serialize<float>(initiativeWithSkipIntroMessageDuration, name: "initiativeWithSkipIntroMessageDuration");
			placeAlliesTextBoxAboveHead = s.Serialize<bool>(placeAlliesTextBoxAboveHead, name: "placeAlliesTextBoxAboveHead", options: CSerializerObject.Options.BoolAsByte);
			placeEnemyTextBoxAboveHead = s.Serialize<bool>(placeEnemyTextBoxAboveHead, name: "placeEnemyTextBoxAboveHead", options: CSerializerObject.Options.BoolAsByte);
			alliesTextBoxVerticalOffset = s.Serialize<float>(alliesTextBoxVerticalOffset, name: "alliesTextBoxVerticalOffset");
			enemyTextBoxVerticalOffset = s.Serialize<float>(enemyTextBoxVerticalOffset, name: "enemyTextBoxVerticalOffset");
			overlapPosOffset = s.Serialize<float>(overlapPosOffset, name: "overlapPosOffset");
			overlapTimeOffset = s.Serialize<float>(overlapTimeOffset, name: "overlapTimeOffset");
			secondaryOverlapPosOffset = s.Serialize<float>(secondaryOverlapPosOffset, name: "secondaryOverlapPosOffset");
			secondaryOverlapTimeOffset = s.Serialize<float>(secondaryOverlapTimeOffset, name: "secondaryOverlapTimeOffset");
			doubleFirstMessageOverlapPosOffset = s.Serialize<float>(doubleFirstMessageOverlapPosOffset, name: "doubleFirstMessageOverlapPosOffset");
			doubleFirstMessageOverlapTimeOffset = s.Serialize<float>(doubleFirstMessageOverlapTimeOffset, name: "doubleFirstMessageOverlapTimeOffset");
		}
		public override uint? ClassCRC => 0x79FD7E95;
	}
}

