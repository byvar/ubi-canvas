namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventDarkRayman : Event {
		public float activateDelaySec;
		public bool attackOwner;
		public bool attackOthers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activateDelaySec = s.Serialize<float>(activateDelaySec, name: "activateDelaySec");
			attackOwner = s.Serialize<bool>(attackOwner, name: "attackOwner");
			attackOthers = s.Serialize<bool>(attackOthers, name: "attackOthers");
		}
		public override uint? ClassCRC => 0x6F598F25;
	}
}

