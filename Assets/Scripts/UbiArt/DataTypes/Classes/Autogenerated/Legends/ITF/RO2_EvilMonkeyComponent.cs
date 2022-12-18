namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EvilMonkeyComponent : CSerializable {
		public float maxprojectiles;
		public Placeholder ProjectilesDescList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxprojectiles = s.Serialize<float>(maxprojectiles, name: "maxprojectiles");
			ProjectilesDescList = s.SerializeObject<Placeholder>(ProjectilesDescList, name: "ProjectilesDescList");
		}
		public override uint? ClassCRC => 0x546EFC39;
	}
}

