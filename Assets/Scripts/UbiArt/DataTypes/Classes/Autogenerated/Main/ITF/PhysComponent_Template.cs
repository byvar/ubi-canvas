namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PhysComponent_Template : ActorComponent_Template {
		public float physGravityMultiplier = 1f;
		public float physRadius = 1f;
		public float physWeight = 1f;
		public float physWindMultiplier = 1f;
		public float physWaterMultiplier = 1f;
		public float physForce2Speed = 1 / 60f;
		public float physWindSpeedLimit = 20f;
		public float physWindScaleFactorWhenSpeedIsOpposite = 1.5f;
		public float physFanForceMultiplier = 1f;
		public float physWaterMinPerturbation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				physRadius = s.Serialize<float>(physRadius, name: "physRadius");
				physWeight = s.Serialize<float>(physWeight, name: "physWeight");
				physGravityMultiplier = s.Serialize<float>(physGravityMultiplier, name: "physGravityMultiplier");
				physWindMultiplier = s.Serialize<float>(physWindMultiplier, name: "physWindMultiplier");
				physWaterMultiplier = s.Serialize<float>(physWaterMultiplier, name: "physWaterMultiplier");
				physForce2Speed = s.Serialize<float>(physForce2Speed, name: "physForce2Speed");
				physWindSpeedLimit = s.Serialize<float>(physWindSpeedLimit, name: "physWindSpeedLimit");
				physWindScaleFactorWhenSpeedIsOpposite = s.Serialize<float>(physWindScaleFactorWhenSpeedIsOpposite, name: "physWindScaleFactorWhenSpeedIsOpposite");
				physFanForceMultiplier = s.Serialize<float>(physFanForceMultiplier, name: "physFanForceMultiplier");
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				physRadius = s.Serialize<float>(physRadius, name: "physRadius");
				physWeight = s.Serialize<float>(physWeight, name: "physWeight");
				physGravityMultiplier = s.Serialize<float>(physGravityMultiplier, name: "physGravityMultiplier");
				physWindMultiplier = s.Serialize<float>(physWindMultiplier, name: "physWindMultiplier");
				physWaterMultiplier = s.Serialize<float>(physWaterMultiplier, name: "physWaterMultiplier");
				physForce2Speed = s.Serialize<float>(physForce2Speed, name: "physForce2Speed");
				physWindSpeedLimit = s.Serialize<float>(physWindSpeedLimit, name: "physWindSpeedLimit");
				physWindScaleFactorWhenSpeedIsOpposite = s.Serialize<float>(physWindScaleFactorWhenSpeedIsOpposite, name: "physWindScaleFactorWhenSpeedIsOpposite");
				physFanForceMultiplier = s.Serialize<float>(physFanForceMultiplier, name: "physFanForceMultiplier");
				if (s.Settings.platform != Settings.Platform.Vita) {
					physWaterMinPerturbation = s.Serialize<float>(physWaterMinPerturbation, name: "physWaterMinPerturbation");
				}
			} else {
				physGravityMultiplier = s.Serialize<float>(physGravityMultiplier, name: "physGravityMultiplier");
			}
		}
		public override uint? ClassCRC => 0x9EAA0C3B;
	}
}

