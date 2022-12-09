namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ChildLaunchComponent : ActorComponent {
		public uint nextLaunchIndex;
		public bool hintFxEnabled = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				nextLaunchIndex = s.Serialize<uint>(nextLaunchIndex, name: "nextLaunchIndex");
			}
			if (s.HasFlags(SerializeFlags.Default)) {
				hintFxEnabled = s.Serialize<bool>(hintFxEnabled, name: "hintFxEnabled");
			}
		}
		public override uint? ClassCRC => 0xDA6C4598;
	}
}

