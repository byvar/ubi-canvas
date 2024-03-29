namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ParticlePhysComponent_Template : PhysComponent_Template {
		public float physFriction;
		public float physAngularSpeedMinLinear = 1f;
		public float physAngularSpeedMaxLinear = 10f;
		public Angle physAngularSpeedMinAngular = 150f;
		public Angle physAngularSpeedMaxAngular = 250f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO || s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
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

