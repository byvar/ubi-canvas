namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SkullCoinBTAIComponent : BTAIComponent {
		public bool exploded;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				exploded = s.Serialize<bool>(exploded, name: "exploded");
			}
		}
		public override uint? ClassCRC => 0xDD1D9FC2;
	}
}

