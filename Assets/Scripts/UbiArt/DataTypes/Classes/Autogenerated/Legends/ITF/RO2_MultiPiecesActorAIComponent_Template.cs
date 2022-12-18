namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_MultiPiecesActorAIComponent_Template : CSerializable {
		public Placeholder piecesDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			piecesDataList = s.SerializeObject<Placeholder>(piecesDataList, name: "piecesDataList");
		}
		public override uint? ClassCRC => 0xA4369574;
	}
}

