namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EventIsInfluencedByVacuum : CSerializable {
		public int influenced;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			influenced = s.Serialize<int>(influenced, name: "influenced");
		}
		public override uint? ClassCRC => 0xB6919914;
	}
}

