using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GameProgress : CSerializable {
		public StringID Name;
		public CList<GameProgress> GameProgressList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Name = s.SerializeObject<StringID>(Name, name: "Name");
			GameProgressList = s.SerializeObject<CList<GameProgress>>(GameProgressList, name: "GameProgressList");
		}
	}
}

