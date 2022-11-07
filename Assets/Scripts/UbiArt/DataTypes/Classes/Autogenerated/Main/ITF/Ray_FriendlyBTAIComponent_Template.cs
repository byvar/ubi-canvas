namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_FriendlyBTAIComponent_Template : BTAIComponent_Template {
		public float retaliationDuration;
		public float squashDeathPenetration;
		public Path darktoonSpawn;
		public int disappearOnRescue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			retaliationDuration = s.Serialize<float>(retaliationDuration, name: "retaliationDuration");
			squashDeathPenetration = s.Serialize<float>(squashDeathPenetration, name: "squashDeathPenetration");
			darktoonSpawn = s.SerializeObject<Path>(darktoonSpawn, name: "darktoonSpawn");
			disappearOnRescue = s.Serialize<int>(disappearOnRescue, name: "disappearOnRescue");
		}
		public override uint? ClassCRC => 0x670E541F;
	}
}

