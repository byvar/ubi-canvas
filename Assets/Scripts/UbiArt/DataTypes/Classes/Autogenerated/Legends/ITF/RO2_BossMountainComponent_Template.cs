namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_BossMountainComponent_Template : ActorComponent_Template {
		public int DrawParticleNb;
		public int DrawBezier;
		public int DrawAppear;
		public int DrawTransition;
		public int DrawSpeed;
		public int DrawHit;
		public int DrawAttack;
		public float TimeBeforeTransition;
		public float DestructionAccelerationCoeff;
		public float CreatureBaseRadius;
		public float CreatureRadiusSeeder;
		public float CreatureNbCoeff;
		public CListO<Unknown_RL_20717_sub_6E6EE0> OnBoneData;
		public CListO<StringID> EyeBoneList;
		public int ApplyAnimMod;
		public StringID TailBone;
		public StringID HeadBone;
		public Path lightResolver;
		public StringID AnimStand;
		public StringID AnimHit;
		public StringID AnimRegroup;
		public StringID AnimScared;
		public StringID AnimBlood;
		public StringID AnimEye;
		public StringID AnimDie;
		public float MinBurningTime;
		public float MaxBurningTime;
		public float MinTimeToDie;
		public float MaxTimeToDie;
		public float MinRegenTime;
		public float MaxRegenTime;
		public float AirFriction;
		public float Gravity;
		public float ExplosionForceMultiplier;
		public float ExplosionInitialSpeed;
		public CListP<float> PunchExplosionRadius;
		public float PunchPercentageValidation;
		public float TimeToVanish;
		public float RotationCoeff;
		public float RegroupSpeed;
		public float RegroupAirFriction;
		public float RegroupForce;
		public float RegroupMinTime;
		public float RegroupMaxTime;
		public StringID SoundFX_Idle;
		public StringID SoundFX_Hit;
		public StringID SounfFX_Respawn;
		public StringID SoundFX_Destroy;
		public StringID SoundFX_Appear;
		public int AttackAnimAllowed;
		public float AttackAnimDistance;
		public int RandomLaughAllowed;
		public float RandomLaughMinTime;
		public float RandomLaughMaxTime;
		public int UseFinalExplosion;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DrawParticleNb = s.Serialize<int>(DrawParticleNb, name: "DrawParticleNb");
			DrawBezier = s.Serialize<int>(DrawBezier, name: "DrawBezier");
			DrawAppear = s.Serialize<int>(DrawAppear, name: "DrawAppear");
			DrawTransition = s.Serialize<int>(DrawTransition, name: "DrawTransition");
			DrawSpeed = s.Serialize<int>(DrawSpeed, name: "DrawSpeed");
			DrawHit = s.Serialize<int>(DrawHit, name: "DrawHit");
			DrawAttack = s.Serialize<int>(DrawAttack, name: "DrawAttack");
			TimeBeforeTransition = s.Serialize<float>(TimeBeforeTransition, name: "TimeBeforeTransition");
			DestructionAccelerationCoeff = s.Serialize<float>(DestructionAccelerationCoeff, name: "DestructionAccelerationCoeff");
			CreatureBaseRadius = s.Serialize<float>(CreatureBaseRadius, name: "CreatureBaseRadius");
			CreatureRadiusSeeder = s.Serialize<float>(CreatureRadiusSeeder, name: "CreatureRadiusSeeder");
			CreatureNbCoeff = s.Serialize<float>(CreatureNbCoeff, name: "CreatureNbCoeff");
			OnBoneData = s.SerializeObject<CListO<Unknown_RL_20717_sub_6E6EE0>>(OnBoneData, name: "OnBoneData");
			EyeBoneList = s.SerializeObject<CListO<StringID>>(EyeBoneList, name: "EyeBoneList");
			ApplyAnimMod = s.Serialize<int>(ApplyAnimMod, name: "ApplyAnimMod");
			TailBone = s.SerializeObject<StringID>(TailBone, name: "TailBone");
			HeadBone = s.SerializeObject<StringID>(HeadBone, name: "HeadBone");
			lightResolver = s.SerializeObject<Path>(lightResolver, name: "lightResolver");
			AnimStand = s.SerializeObject<StringID>(AnimStand, name: "AnimStand");
			AnimHit = s.SerializeObject<StringID>(AnimHit, name: "AnimHit");
			AnimRegroup = s.SerializeObject<StringID>(AnimRegroup, name: "AnimRegroup");
			AnimScared = s.SerializeObject<StringID>(AnimScared, name: "AnimScared");
			AnimBlood = s.SerializeObject<StringID>(AnimBlood, name: "AnimBlood");
			AnimEye = s.SerializeObject<StringID>(AnimEye, name: "AnimEye");
			AnimDie = s.SerializeObject<StringID>(AnimDie, name: "AnimDie");
			MinBurningTime = s.Serialize<float>(MinBurningTime, name: "MinBurningTime");
			MaxBurningTime = s.Serialize<float>(MaxBurningTime, name: "MaxBurningTime");
			MinTimeToDie = s.Serialize<float>(MinTimeToDie, name: "MinTimeToDie");
			MaxTimeToDie = s.Serialize<float>(MaxTimeToDie, name: "MaxTimeToDie");
			MinRegenTime = s.Serialize<float>(MinRegenTime, name: "MinRegenTime");
			MaxRegenTime = s.Serialize<float>(MaxRegenTime, name: "MaxRegenTime");
			AirFriction = s.Serialize<float>(AirFriction, name: "AirFriction");
			Gravity = s.Serialize<float>(Gravity, name: "Gravity");
			ExplosionForceMultiplier = s.Serialize<float>(ExplosionForceMultiplier, name: "ExplosionForceMultiplier");
			ExplosionInitialSpeed = s.Serialize<float>(ExplosionInitialSpeed, name: "ExplosionInitialSpeed");
			PunchExplosionRadius = s.SerializeObject<CListP<float>>(PunchExplosionRadius, name: "PunchExplosionRadius");
			PunchPercentageValidation = s.Serialize<float>(PunchPercentageValidation, name: "PunchPercentageValidation");
			TimeToVanish = s.Serialize<float>(TimeToVanish, name: "TimeToVanish");
			RotationCoeff = s.Serialize<float>(RotationCoeff, name: "RotationCoeff");
			RegroupSpeed = s.Serialize<float>(RegroupSpeed, name: "RegroupSpeed");
			RegroupAirFriction = s.Serialize<float>(RegroupAirFriction, name: "RegroupAirFriction");
			RegroupForce = s.Serialize<float>(RegroupForce, name: "RegroupForce");
			RegroupMinTime = s.Serialize<float>(RegroupMinTime, name: "RegroupMinTime");
			RegroupMaxTime = s.Serialize<float>(RegroupMaxTime, name: "RegroupMaxTime");
			SoundFX_Idle = s.SerializeObject<StringID>(SoundFX_Idle, name: "SoundFX_Idle");
			SoundFX_Hit = s.SerializeObject<StringID>(SoundFX_Hit, name: "SoundFX_Hit");
			SounfFX_Respawn = s.SerializeObject<StringID>(SounfFX_Respawn, name: "SounfFX_Respawn");
			SoundFX_Destroy = s.SerializeObject<StringID>(SoundFX_Destroy, name: "SoundFX_Destroy");
			SoundFX_Appear = s.SerializeObject<StringID>(SoundFX_Appear, name: "SoundFX_Appear");
			AttackAnimAllowed = s.Serialize<int>(AttackAnimAllowed, name: "AttackAnimAllowed");
			AttackAnimDistance = s.Serialize<float>(AttackAnimDistance, name: "AttackAnimDistance");
			RandomLaughAllowed = s.Serialize<int>(RandomLaughAllowed, name: "RandomLaughAllowed");
			RandomLaughMinTime = s.Serialize<float>(RandomLaughMinTime, name: "RandomLaughMinTime");
			RandomLaughMaxTime = s.Serialize<float>(RandomLaughMaxTime, name: "RandomLaughMaxTime");
			UseFinalExplosion = s.Serialize<int>(UseFinalExplosion, name: "UseFinalExplosion");
		}
		public override uint? ClassCRC => 0x6AAD0104;

		[Games(GameFlags.RL)]
		public partial class Unknown_RL_20717_sub_6E6EE0 : CSerializable {
			public StringID BoneName;
			public uint CreatureNb;
			public float Scale;
			public float Radius;
			public int IsFlat;
			public StringID FlatBoneOne;
			public StringID FlatBoneTwo;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				BoneName = s.SerializeObject<StringID>(BoneName, name: "BoneName");
				CreatureNb = s.Serialize<uint>(CreatureNb, name: "CreatureNb");
				Scale = s.Serialize<float>(Scale, name: "Scale");
				Radius = s.Serialize<float>(Radius, name: "Radius");
				IsFlat = s.Serialize<int>(IsFlat, name: "IsFlat");
				FlatBoneOne = s.SerializeObject<StringID>(FlatBoneOne, name: "FlatBoneOne");
				FlatBoneTwo = s.SerializeObject<StringID>(FlatBoneTwo, name: "FlatBoneTwo");
			}
		}
	}
}

