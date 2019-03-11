using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionThrowStone_Template : BTAction_Template {
		[Serialize("enemyDetectionRange"     )] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("animCreateProjectile"    )] public StringID animCreateProjectile;
		[Serialize("animWait"                )] public StringID animWait;
		[Serialize("animFire"                )] public StringID animFire;
		[Serialize("attack_MRK_Name"         )] public StringID attack_MRK_Name;
		[Serialize("boneNameSnap"            )] public StringID boneNameSnap;
		[Serialize("useBoneOrientation"      )] public bool useBoneOrientation;
		[Serialize("typeAttack"              )] public uint typeAttack;
		[Serialize("defaultDir"              )] public Vector2 defaultDir;
		[Serialize("projectilesPath"         )] public Path projectilesPath;
		[Serialize("countProjectilesPrealloc")] public uint countProjectilesPrealloc;
		[Serialize("countProjectilesMax"     )] public uint countProjectilesMax;
		[Serialize("projectileSpeed"         )] public float projectileSpeed;
		[Serialize("debug"                   )] public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(animCreateProjectile));
			SerializeField(s, nameof(animWait));
			SerializeField(s, nameof(animFire));
			SerializeField(s, nameof(attack_MRK_Name));
			SerializeField(s, nameof(boneNameSnap));
			SerializeField(s, nameof(useBoneOrientation));
			SerializeField(s, nameof(typeAttack));
			SerializeField(s, nameof(defaultDir));
			SerializeField(s, nameof(projectilesPath));
			SerializeField(s, nameof(countProjectilesPrealloc));
			SerializeField(s, nameof(countProjectilesMax));
			SerializeField(s, nameof(projectileSpeed));
			SerializeField(s, nameof(debug));
		}
		public override uint? ClassCRC => 0x58C2CF7C;
	}
}

