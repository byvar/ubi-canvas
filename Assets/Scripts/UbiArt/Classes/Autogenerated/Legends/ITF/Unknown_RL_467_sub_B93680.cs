using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_467_sub_B93680 : CSerializable {
		public Placeholder piecesDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			piecesDataList = s.SerializeObject<Placeholder>(piecesDataList, name: "piecesDataList");
		}
		public override uint? ClassCRC => 0xA4369574;
	}
}

