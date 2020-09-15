using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class MapProgressContainer : CSerializable {
		public CList<GameProgress> GameProgressList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			GameProgressList = s.SerializeObject<CList<GameProgress>>(GameProgressList, name: "GameProgressList");
		}
	}
}

