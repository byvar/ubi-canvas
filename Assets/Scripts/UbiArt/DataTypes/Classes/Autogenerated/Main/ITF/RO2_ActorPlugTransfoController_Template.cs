namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ActorPlugTransfoController_Template : ActorPlugPlayableController_Template {
		public float autoUnplugDelay;
		public float autoUnplugWarning;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			autoUnplugDelay = s.Serialize<float>(autoUnplugDelay, name: "autoUnplugDelay");
			autoUnplugWarning = s.Serialize<float>(autoUnplugWarning, name: "autoUnplugWarning");
		}
		public override uint? ClassCRC => 0x9EEEA27C;
	}
}

