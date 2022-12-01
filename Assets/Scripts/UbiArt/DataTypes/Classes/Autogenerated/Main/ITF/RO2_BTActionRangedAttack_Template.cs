namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionRangedAttack_Template : BTAction_Template {
		public Generic<PhysShape> enemyDetectionRange;
		public StringID animAim;
		public StringID animFire;
		public StringID attack_MRK_Name;
		public StringID boneNameSnap;
		public StringID anticipFxName;
		public uint typeAttack;
		public Vec2d defaultDir = Vec2d.Right;
		public Path projectilesPath;
		public uint countProjectilesPrealloc = 1;
		public uint countProjectilesMax = 1;
		public float smoothFactorAngle = 1f;
		public float timeAim;
		public float timeAnticip;
		public Vec2d aimOffset;
		public bool debug;
		public bool useDetection = true;
		public bool scaleDetectionRange = true;
		public bool releaseBetweenSequences;
		public float recoil;
		public StringID specificPhantomShape;
		public bool useTutoOnBullet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			animAim = s.SerializeObject<StringID>(animAim, name: "animAim");
			animFire = s.SerializeObject<StringID>(animFire, name: "animFire");
			attack_MRK_Name = s.SerializeObject<StringID>(attack_MRK_Name, name: "attack_MRK_Name");
			boneNameSnap = s.SerializeObject<StringID>(boneNameSnap, name: "boneNameSnap");
			anticipFxName = s.SerializeObject<StringID>(anticipFxName, name: "anticipFxName");
			typeAttack = s.Serialize<uint>(typeAttack, name: "typeAttack");
			defaultDir = s.SerializeObject<Vec2d>(defaultDir, name: "defaultDir");
			projectilesPath = s.SerializeObject<Path>(projectilesPath, name: "projectilesPath");
			countProjectilesPrealloc = s.Serialize<uint>(countProjectilesPrealloc, name: "countProjectilesPrealloc");
			countProjectilesMax = s.Serialize<uint>(countProjectilesMax, name: "countProjectilesMax");
			smoothFactorAngle = s.Serialize<float>(smoothFactorAngle, name: "smoothFactorAngle");
			timeAim = s.Serialize<float>(timeAim, name: "timeAim");
			timeAnticip = s.Serialize<float>(timeAnticip, name: "timeAnticip");
			aimOffset = s.SerializeObject<Vec2d>(aimOffset, name: "aimOffset");
			debug = s.Serialize<bool>(debug, name: "debug");
			useDetection = s.Serialize<bool>(useDetection, name: "useDetection");
			scaleDetectionRange = s.Serialize<bool>(scaleDetectionRange, name: "scaleDetectionRange");
			releaseBetweenSequences = s.Serialize<bool>(releaseBetweenSequences, name: "releaseBetweenSequences");
			recoil = s.Serialize<float>(recoil, name: "recoil");
			specificPhantomShape = s.SerializeObject<StringID>(specificPhantomShape, name: "specificPhantomShape");
			useTutoOnBullet = s.Serialize<bool>(useTutoOnBullet, name: "useTutoOnBullet");
		}
		public override uint? ClassCRC => 0xF47B2867;
	}
}

