using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ParticlePhysComponent_Template : PhysComponent_Template {
		public float physFriction;
		public float physAngularSpeedMinLinear;
		public float physAngularSpeedMaxLinear;
		public Angle physAngularSpeedMinAngular;
		public Angle physAngularSpeedMaxAngular;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				physFriction = s.Serialize<float>(physFriction, name: "physFriction");
				physAngularSpeedMinLinear = s.Serialize<float>(physAngularSpeedMinLinear, name: "physAngularSpeedMinLinear");
				physAngularSpeedMaxLinear = s.Serialize<float>(physAngularSpeedMaxLinear, name: "physAngularSpeedMaxLinear");
				physAngularSpeedMinAngular = s.SerializeObject<Angle>(physAngularSpeedMinAngular, name: "physAngularSpeedMinAngular");
				physAngularSpeedMaxAngular = s.SerializeObject<Angle>(physAngularSpeedMaxAngular, name: "physAngularSpeedMaxAngular");
			} else {
				physFriction = s.Serialize<float>(physFriction, name: "physFriction");
				physAngularSpeedMinLinear = s.Serialize<float>(physAngularSpeedMinLinear, name: "physAngularSpeedMinLinear");
				physAngularSpeedMaxLinear = s.Serialize<float>(physAngularSpeedMaxLinear, name: "physAngularSpeedMaxLinear");
				physAngularSpeedMinAngular = s.SerializeObject<Angle>(physAngularSpeedMinAngular, name: "physAngularSpeedMinAngular");
				physAngularSpeedMaxAngular = s.SerializeObject<Angle>(physAngularSpeedMaxAngular, name: "physAngularSpeedMaxAngular");
				physWindMultiplier = s.Serialize<float>(physWindMultiplier, name: "physWindMultiplier");
				physForce2Speed = s.Serialize<float>(physForce2Speed, name: "physForce2Speed");
				physWindSpeedLimit = s.Serialize<float>(physWindSpeedLimit, name: "physWindSpeedLimit");
				physWindScaleFactorWhenSpeedIsOpposite = s.Serialize<float>(physWindScaleFactorWhenSpeedIsOpposite, name: "physWindScaleFactorWhenSpeedIsOpposite");
				physFanForceMultiplier = s.Serialize<float>(physFanForceMultiplier, name: "physFanForceMultiplier");
			}
		}
		public override uint? ClassCRC => 0xC53BC898;
	}
}

