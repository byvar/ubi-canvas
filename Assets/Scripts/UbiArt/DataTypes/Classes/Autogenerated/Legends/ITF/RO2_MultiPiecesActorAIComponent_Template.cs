namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_MultiPiecesActorAIComponent_Template : RO2_AIComponent_Template {
		public CListO<PieceData> piecesDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			piecesDataList = s.SerializeObject<CListO<PieceData>>(piecesDataList, name: "piecesDataList");
		}
		public override uint? ClassCRC => 0xA4369574;
	}
}

