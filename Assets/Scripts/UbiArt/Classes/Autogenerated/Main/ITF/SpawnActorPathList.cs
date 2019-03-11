using UnityEngine;

namespace UbiArt.ITF {
	public partial class SpawnActorPathList : CSerializable {
		[Serialize("tutoList")] public CList<SpawnActorPathTuto> tutoList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tutoList));
		}
	}
}

