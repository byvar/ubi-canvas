namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_LightingMushroomComponent : ActorComponent {
		public bool IsMoving;
		public float ScaleMin = 0.8f;
		public float ScaleMax = 1.1f;
		public bool StayLightingAfterHit;
		public bool AlwaysLighting;
		public Size ExplosionRadius = Size.Medium;
		public uint RocketNb = 1;
		public bool SteadyExplosion;
		public float TimeToStartFalling;
		public CListO<RO2_LightingMushroomComponent.MushroomTarget> MushroomTargets;
		public uint GPEColor = 0xFFFFFFFF;
		public bool fireOnce;
		public bool triggerSpawn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					IsMoving = s.Serialize<bool>(IsMoving, name: "IsMoving");
					ScaleMin = s.Serialize<float>(ScaleMin, name: "ScaleMin");
					ScaleMax = s.Serialize<float>(ScaleMax, name: "ScaleMax");
					StayLightingAfterHit = s.Serialize<bool>(StayLightingAfterHit, name: "StayLightingAfterHit");
					AlwaysLighting = s.Serialize<bool>(AlwaysLighting, name: "AlwaysLighting");
					ExplosionRadius = s.Serialize<Size>(ExplosionRadius, name: "ExplosionRadius");
					RocketNb = s.Serialize<uint>(RocketNb, name: "RocketNb");
					SteadyExplosion = s.Serialize<bool>(SteadyExplosion, name: "SteadyExplosion");
					TimeToStartFalling = s.Serialize<float>(TimeToStartFalling, name: "TimeToStartFalling");
					MushroomTargets = s.SerializeObject<CListO<RO2_LightingMushroomComponent.MushroomTarget>>(MushroomTargets, name: "MushroomTargets");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					IsMoving = s.Serialize<bool>(IsMoving, name: "IsMoving");
					ScaleMin = s.Serialize<float>(ScaleMin, name: "ScaleMin");
					ScaleMax = s.Serialize<float>(ScaleMax, name: "ScaleMax");
					StayLightingAfterHit = s.Serialize<bool>(StayLightingAfterHit, name: "StayLightingAfterHit");
					AlwaysLighting = s.Serialize<bool>(AlwaysLighting, name: "AlwaysLighting");
					ExplosionRadius = s.Serialize<Size>(ExplosionRadius, name: "ExplosionRadius");
					RocketNb = s.Serialize<uint>(RocketNb, name: "RocketNb");
					SteadyExplosion = s.Serialize<bool>(SteadyExplosion, name: "SteadyExplosion");
					TimeToStartFalling = s.Serialize<float>(TimeToStartFalling, name: "TimeToStartFalling");
					MushroomTargets = s.SerializeObject<CListO<RO2_LightingMushroomComponent.MushroomTarget>>(MushroomTargets, name: "MushroomTargets");
					GPEColor = s.Serialize<uint>(GPEColor, name: "GPEColor");
					fireOnce = s.Serialize<bool>(fireOnce, name: "fireOnce");
					triggerSpawn = s.Serialize<bool>(triggerSpawn, name: "triggerSpawn");
				}
			}
		}
		[Games(GameFlags.RL | GameFlags.RA)]
		public partial class MushroomTarget : CSerializable {
			public Vec3d Position;
			public float ExplosionTimer;
			public float flareSpeed;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.Settings.game == Settings.Game.RL) {
					if (s.HasFlags(SerializeFlags.Default)) {
						Position = s.SerializeObject<Vec3d>(Position, name: "Position");
						ExplosionTimer = s.Serialize<float>(ExplosionTimer, name: "ExplosionTimer");
					}
				} else {
					if (s.HasFlags(SerializeFlags.Default)) {
						Position = s.SerializeObject<Vec3d>(Position, name: "Position");
						ExplosionTimer = s.Serialize<float>(ExplosionTimer, name: "ExplosionTimer");
						flareSpeed = s.Serialize<float>(flareSpeed, name: "flareSpeed");
					}
				}
			}
		}
		public enum Size {
			[Serialize("SizeSmall" )] Small = 0,
			[Serialize("SizeMedium")] Medium = 1,
			[Serialize("SizeLarge" )] Large = 2,
			[Serialize("SizeXLarge")] XLarge = 3,
		}
		public override uint? ClassCRC => 0xB1E5E5CC;
	}
}

