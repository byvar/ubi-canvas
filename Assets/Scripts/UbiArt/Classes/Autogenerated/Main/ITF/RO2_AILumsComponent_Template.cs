using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AILumsComponent_Template : ActorComponent_Template {
		[Serialize("playerDetectorMultiplierInWater")] public float playerDetectorMultiplierInWater;
		[Serialize("grabAttractiveForceValue"       )] public float grabAttractiveForceValue;
		[Serialize("grabMaxRepulsiveForce"          )] public float grabMaxRepulsiveForce;
		[Serialize("grabRepulsionRadius"            )] public float grabRepulsionRadius;
		[Serialize("grabDampingFactor"              )] public float grabDampingFactor;
		[Serialize("timeBeforeTaken"                )] public float timeBeforeTaken;
		[Serialize("followingOffset"                )] public Vec2d followingOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(playerDetectorMultiplierInWater));
			} else {
				SerializeField(s, nameof(playerDetectorMultiplierInWater));
				SerializeField(s, nameof(grabAttractiveForceValue));
				SerializeField(s, nameof(grabMaxRepulsiveForce));
				SerializeField(s, nameof(grabRepulsionRadius));
				SerializeField(s, nameof(grabDampingFactor));
				SerializeField(s, nameof(timeBeforeTaken));
				SerializeField(s, nameof(followingOffset));
			}
		}
		public override uint? ClassCRC => 0x781ECA51;
	}
}

