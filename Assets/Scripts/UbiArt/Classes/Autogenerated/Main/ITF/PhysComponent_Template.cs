using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysComponent_Template : ActorComponent_Template {
		[Serialize("physGravityMultiplier"                 )] public float physGravityMultiplier;
		[Serialize("physRadius"                            )] public float physRadius;
		[Serialize("physWeight"                            )] public float physWeight;
		[Serialize("physWindMultiplier"                    )] public float physWindMultiplier;
		[Serialize("physWaterMultiplier"                   )] public float physWaterMultiplier;
		[Serialize("physForce2Speed"                       )] public float physForce2Speed;
		[Serialize("physWindSpeedLimit"                    )] public float physWindSpeedLimit;
		[Serialize("physWindScaleFactorWhenSpeedIsOpposite")] public float physWindScaleFactorWhenSpeedIsOpposite;
		[Serialize("physFanForceMultiplier"                )] public float physFanForceMultiplier;
		[Serialize("physWaterMinPerturbation"              )] public float physWaterMinPerturbation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(physRadius));
				SerializeField(s, nameof(physWeight));
				SerializeField(s, nameof(physGravityMultiplier));
				SerializeField(s, nameof(physWindMultiplier));
				SerializeField(s, nameof(physWaterMultiplier));
				SerializeField(s, nameof(physForce2Speed));
				SerializeField(s, nameof(physWindSpeedLimit));
				SerializeField(s, nameof(physWindScaleFactorWhenSpeedIsOpposite));
				SerializeField(s, nameof(physFanForceMultiplier));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(physRadius));
				SerializeField(s, nameof(physWeight));
				SerializeField(s, nameof(physGravityMultiplier));
				SerializeField(s, nameof(physWindMultiplier));
				SerializeField(s, nameof(physWaterMultiplier));
				SerializeField(s, nameof(physForce2Speed));
				SerializeField(s, nameof(physWindSpeedLimit));
				SerializeField(s, nameof(physWindScaleFactorWhenSpeedIsOpposite));
				SerializeField(s, nameof(physFanForceMultiplier));
				SerializeField(s, nameof(physWaterMinPerturbation));
			} else {
				SerializeField(s, nameof(physGravityMultiplier));
			}
		}
		public override uint? ClassCRC => 0x9EAA0C3B;
	}
}

