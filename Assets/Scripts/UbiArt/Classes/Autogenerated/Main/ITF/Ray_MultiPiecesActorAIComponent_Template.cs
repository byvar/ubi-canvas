using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_MultiPiecesActorAIComponent_Template : Ray_AIComponent_Template {
		public CListO<PieceData> piecesDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			piecesDataList = s.SerializeObject<CListO<PieceData>>(piecesDataList, name: "piecesDataList");
		}
		public override uint? ClassCRC => 0xD2404FEB;
	}
}

