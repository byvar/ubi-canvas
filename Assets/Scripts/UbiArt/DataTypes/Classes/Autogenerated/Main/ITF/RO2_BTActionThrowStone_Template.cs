namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionThrowStone_Template : BTAction_Template {
		public Generic<PhysShape> enemyDetectionRange;
		public StringID animCreateProjectile;
		public StringID animWait;
		public StringID animFire;
		public StringID attack_MRK_Name;
		public StringID boneNameSnap;
		public bool useBoneOrientation;
		public uint typeAttack;
		public Vec2d defaultDir = Vec2d.Right;
		public Path projectilesPath;
		public uint countProjectilesPrealloc = 1;
		public uint countProjectilesMax = 1;
		public float projectileSpeed = 7f;
		public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			animCreateProjectile = s.SerializeObject<StringID>(animCreateProjectile, name: "animCreateProjectile");
			animWait = s.SerializeObject<StringID>(animWait, name: "animWait");
			animFire = s.SerializeObject<StringID>(animFire, name: "animFire");
			attack_MRK_Name = s.SerializeObject<StringID>(attack_MRK_Name, name: "attack_MRK_Name");
			boneNameSnap = s.SerializeObject<StringID>(boneNameSnap, name: "boneNameSnap");
			useBoneOrientation = s.Serialize<bool>(useBoneOrientation, name: "useBoneOrientation");
			typeAttack = s.Serialize<uint>(typeAttack, name: "typeAttack");
			defaultDir = s.SerializeObject<Vec2d>(defaultDir, name: "defaultDir");
			projectilesPath = s.SerializeObject<Path>(projectilesPath, name: "projectilesPath");
			countProjectilesPrealloc = s.Serialize<uint>(countProjectilesPrealloc, name: "countProjectilesPrealloc");
			countProjectilesMax = s.Serialize<uint>(countProjectilesMax, name: "countProjectilesMax");
			projectileSpeed = s.Serialize<float>(projectileSpeed, name: "projectileSpeed");
			debug = s.Serialize<bool>(debug, name: "debug");
		}
		public override uint? ClassCRC => 0x58C2CF7C;
	}
}

