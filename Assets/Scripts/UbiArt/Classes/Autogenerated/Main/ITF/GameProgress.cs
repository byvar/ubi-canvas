using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GameProgress : CSerializable {
		[Serialize("Name"            )] public StringID Name;
		[Serialize("GameProgressList")] public CList<GameProgress> GameProgressList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Name));
			SerializeField(s, nameof(GameProgressList));
		}
	}
}

