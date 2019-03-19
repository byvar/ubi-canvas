using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class ParticlePhysComponent_Template : PhysComponent_Template {
		[Serialize("physFriction"                          )] public float physFriction;
		[Serialize("physAngularSpeedMinLinear"             )] public float physAngularSpeedMinLinear;
		[Serialize("physAngularSpeedMaxLinear"             )] public float physAngularSpeedMaxLinear;
		[Serialize("physAngularSpeedMinAngular"            )] public Angle physAngularSpeedMinAngular;
		[Serialize("physAngularSpeedMaxAngular"            )] public Angle physAngularSpeedMaxAngular;
		[Serialize("physWindMultiplier"                    )] public float physWindMultiplier;
		[Serialize("physForce2Speed"                       )] public float physForce2Speed;
		[Serialize("physWindSpeedLimit"                    )] public float physWindSpeedLimit;
		[Serialize("physWindScaleFactorWhenSpeedIsOpposite")] public float physWindScaleFactorWhenSpeedIsOpposite;
		[Serialize("physFanForceMultiplier"                )] public float physFanForceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(physFriction));
				SerializeField(s, nameof(physAngularSpeedMinLinear));
				SerializeField(s, nameof(physAngularSpeedMaxLinear));
				SerializeField(s, nameof(physAngularSpeedMinAngular));
				SerializeField(s, nameof(physAngularSpeedMaxAngular));
			} else {
				SerializeField(s, nameof(physFriction));
				SerializeField(s, nameof(physAngularSpeedMinLinear));
				SerializeField(s, nameof(physAngularSpeedMaxLinear));
				SerializeField(s, nameof(physAngularSpeedMinAngular));
				SerializeField(s, nameof(physAngularSpeedMaxAngular));
				SerializeField(s, nameof(physWindMultiplier));
				SerializeField(s, nameof(physForce2Speed));
				SerializeField(s, nameof(physWindSpeedLimit));
				SerializeField(s, nameof(physWindScaleFactorWhenSpeedIsOpposite));
				SerializeField(s, nameof(physFanForceMultiplier));
			}
		}
		public override uint? ClassCRC => 0xC53BC898;
	}
}

