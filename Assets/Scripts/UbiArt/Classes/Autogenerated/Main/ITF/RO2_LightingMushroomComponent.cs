using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LightingMushroomComponent : ActorComponent {
		[Serialize("IsMoving"            )] public bool IsMoving;
		[Serialize("ScaleMin"            )] public float ScaleMin;
		[Serialize("ScaleMax"            )] public float ScaleMax;
		[Serialize("StayLightingAfterHit")] public bool StayLightingAfterHit;
		[Serialize("AlwaysLighting"      )] public bool AlwaysLighting;
		[Serialize("ExplosionRadius"     )] public Size ExplosionRadius;
		[Serialize("RocketNb"            )] public uint RocketNb;
		[Serialize("SteadyExplosion"     )] public bool SteadyExplosion;
		[Serialize("TimeToStartFalling"  )] public float TimeToStartFalling;
		[Serialize("MushroomTargets"     )] public CList<RO2_LightingMushroomComponent.MushroomTarget> MushroomTargets;
		[Serialize("GPEColor"            )] public uint GPEColor;
		[Serialize("fireOnce"            )] public bool fireOnce;
		[Serialize("triggerSpawn"        )] public bool triggerSpawn;
		[Serialize("ExplosionRadius"     )] public Enum_ExplosionRadius ExplosionRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(IsMoving));
					SerializeField(s, nameof(ScaleMin));
					SerializeField(s, nameof(ScaleMax));
					SerializeField(s, nameof(StayLightingAfterHit));
					SerializeField(s, nameof(AlwaysLighting));
					SerializeField(s, nameof(ExplosionRadius));
					SerializeField(s, nameof(RocketNb));
					SerializeField(s, nameof(SteadyExplosion));
					SerializeField(s, nameof(TimeToStartFalling));
					SerializeField(s, nameof(MushroomTargets));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(IsMoving));
					SerializeField(s, nameof(ScaleMin));
					SerializeField(s, nameof(ScaleMax));
					SerializeField(s, nameof(StayLightingAfterHit));
					SerializeField(s, nameof(AlwaysLighting));
					SerializeField(s, nameof(ExplosionRadius));
					SerializeField(s, nameof(RocketNb));
					SerializeField(s, nameof(SteadyExplosion));
					SerializeField(s, nameof(TimeToStartFalling));
					SerializeField(s, nameof(MushroomTargets));
					SerializeField(s, nameof(GPEColor));
					SerializeField(s, nameof(fireOnce));
					SerializeField(s, nameof(triggerSpawn));
				}
			}
		}
		[Games(GameFlags.RA)]
		public partial class MushroomTarget : CSerializable {
			[Serialize("Position"      )] public Vector3 Position;
			[Serialize("ExplosionTimer")] public float ExplosionTimer;
			[Serialize("flareSpeed"    )] public float flareSpeed;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Position));
					SerializeField(s, nameof(ExplosionTimer));
					SerializeField(s, nameof(flareSpeed));
				}
			}
		}
		public enum Size {
			[Serialize("SizeSmall" )] Small = 0,
			[Serialize("SizeMedium")] Medium = 1,
			[Serialize("SizeLarge" )] Large = 2,
			[Serialize("SizeXLarge")] XLarge = 3,
		}
		public enum Enum_ExplosionRadius {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0xB1E5E5CC;
	}
}

