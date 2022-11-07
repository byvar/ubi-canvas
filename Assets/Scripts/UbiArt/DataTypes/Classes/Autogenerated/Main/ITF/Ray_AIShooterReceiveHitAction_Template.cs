namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_AIShooterReceiveHitAction_Template : Ray_AIReceiveHitAction_Template {
		public float minStunTime;
		public float maxStunTime;
		public float loopingAnimDuration;
		public StringID stunAnimation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minStunTime = s.Serialize<float>(minStunTime, name: "minStunTime");
			maxStunTime = s.Serialize<float>(maxStunTime, name: "maxStunTime");
			loopingAnimDuration = s.Serialize<float>(loopingAnimDuration, name: "loopingAnimDuration");
			stunAnimation = s.SerializeObject<StringID>(stunAnimation, name: "stunAnimation");
		}
		public override uint? ClassCRC => 0x272808F7;
	}
}

