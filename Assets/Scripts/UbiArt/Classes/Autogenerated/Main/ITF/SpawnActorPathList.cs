using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SpawnActorPathList : CSerializable {
		public CList<SpawnActorPathTuto> tutoList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tutoList = s.SerializeObject<CList<SpawnActorPathTuto>>(tutoList, name: "tutoList");
		}
	}
}

