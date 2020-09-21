using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class MapProgressContainer : CSerializable {
		public CListO<GameProgress> GameProgressList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			GameProgressList = s.SerializeObject<CListO<GameProgress>>(GameProgressList, name: "GameProgressList");
		}
	}
}

