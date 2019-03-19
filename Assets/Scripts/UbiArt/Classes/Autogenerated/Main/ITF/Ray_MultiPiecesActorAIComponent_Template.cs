using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_MultiPiecesActorAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("piecesDataList")] public CList<PieceData> piecesDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(piecesDataList));
		}
		public override uint? ClassCRC => 0xD2404FEB;
	}
}

