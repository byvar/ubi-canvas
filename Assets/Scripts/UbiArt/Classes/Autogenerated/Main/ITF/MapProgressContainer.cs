using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class MapProgressContainer : CSerializable {
		[Serialize("GameProgressList")] public CList<GameProgress> GameProgressList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(GameProgressList));
		}
	}
}

