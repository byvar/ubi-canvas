namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BounceOnPolylinePhysComponent_Template : PhysComponent_Template {
		public float bouncingFactor;
		public float bouncingMinYSpeed;
		public float bouncingPassengerFactor;
		public float bouncingDefaultActorWeight;
		public float bouncingPunchMultiplier;
		public float physAngularRealignSmoothFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				bouncingFactor = s.Serialize<float>(bouncingFactor, name: "bouncingFactor");
				bouncingMinYSpeed = s.Serialize<float>(bouncingMinYSpeed, name: "bouncingMinYSpeed");
				bouncingPassengerFactor = s.Serialize<float>(bouncingPassengerFactor, name: "bouncingPassengerFactor");
				bouncingDefaultActorWeight = s.Serialize<float>(bouncingDefaultActorWeight, name: "bouncingDefaultActorWeight");
				bouncingPunchMultiplier = s.Serialize<float>(bouncingPunchMultiplier, name: "bouncingPunchMultiplier");
				physAngularRealignSmoothFactor = s.Serialize<float>(physAngularRealignSmoothFactor, name: "physAngularRealignSmoothFactor");
			} else {
				bouncingFactor = s.Serialize<float>(bouncingFactor, name: "bouncingFactor");
				bouncingMinYSpeed = s.Serialize<float>(bouncingMinYSpeed, name: "bouncingMinYSpeed");
				bouncingPassengerFactor = s.Serialize<float>(bouncingPassengerFactor, name: "bouncingPassengerFactor");
				bouncingDefaultActorWeight = s.Serialize<float>(bouncingDefaultActorWeight, name: "bouncingDefaultActorWeight");
				bouncingPunchMultiplier = s.Serialize<float>(bouncingPunchMultiplier, name: "bouncingPunchMultiplier");
				physAngularRealignSmoothFactor = s.Serialize<float>(physAngularRealignSmoothFactor, name: "physAngularRealignSmoothFactor");
				physRadius = s.Serialize<float>(physRadius, name: "physRadius");
				physWindMultiplier = s.Serialize<float>(physWindMultiplier, name: "physWindMultiplier");
			}
		}
		public override uint? ClassCRC => 0x18FBE896;
	}
}

