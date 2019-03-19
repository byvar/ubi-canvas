using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionRangedAttack_Template : BTAction_Template {
		[Serialize("enemyDetectionRange"     )] public Generic<PhysShape> enemyDetectionRange;
		[Serialize("animAim"                 )] public StringID animAim;
		[Serialize("animFire"                )] public StringID animFire;
		[Serialize("attack_MRK_Name"         )] public StringID attack_MRK_Name;
		[Serialize("boneNameSnap"            )] public StringID boneNameSnap;
		[Serialize("anticipFxName"           )] public StringID anticipFxName;
		[Serialize("typeAttack"              )] public uint typeAttack;
		[Serialize("defaultDir"              )] public Vector2 defaultDir;
		[Serialize("projectilesPath"         )] public Path projectilesPath;
		[Serialize("countProjectilesPrealloc")] public uint countProjectilesPrealloc;
		[Serialize("countProjectilesMax"     )] public uint countProjectilesMax;
		[Serialize("smoothFactorAngle"       )] public float smoothFactorAngle;
		[Serialize("timeAim"                 )] public float timeAim;
		[Serialize("timeAnticip"             )] public float timeAnticip;
		[Serialize("aimOffset"               )] public Vector2 aimOffset;
		[Serialize("debug"                   )] public bool debug;
		[Serialize("useDetection"            )] public bool useDetection;
		[Serialize("scaleDetectionRange"     )] public bool scaleDetectionRange;
		[Serialize("releaseBetweenSequences" )] public bool releaseBetweenSequences;
		[Serialize("recoil"                  )] public float recoil;
		[Serialize("specificPhantomShape"    )] public StringID specificPhantomShape;
		[Serialize("useTutoOnBullet"         )] public bool useTutoOnBullet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(animAim));
			SerializeField(s, nameof(animFire));
			SerializeField(s, nameof(attack_MRK_Name));
			SerializeField(s, nameof(boneNameSnap));
			SerializeField(s, nameof(anticipFxName));
			SerializeField(s, nameof(typeAttack));
			SerializeField(s, nameof(defaultDir));
			SerializeField(s, nameof(projectilesPath));
			SerializeField(s, nameof(countProjectilesPrealloc));
			SerializeField(s, nameof(countProjectilesMax));
			SerializeField(s, nameof(smoothFactorAngle));
			SerializeField(s, nameof(timeAim));
			SerializeField(s, nameof(timeAnticip));
			SerializeField(s, nameof(aimOffset));
			SerializeField(s, nameof(debug));
			SerializeField(s, nameof(useDetection));
			SerializeField(s, nameof(scaleDetectionRange));
			SerializeField(s, nameof(releaseBetweenSequences));
			SerializeField(s, nameof(recoil));
			SerializeField(s, nameof(specificPhantomShape));
			SerializeField(s, nameof(useTutoOnBullet));
		}
		public override uint? ClassCRC => 0xF47B2867;
	}
}

