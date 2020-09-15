using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_Score : CSerializable {
		public CList<uint> lumCount;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumCount = s.SerializeObject<CList<uint>>(lumCount, name: "lumCount");
		}
	}
}

