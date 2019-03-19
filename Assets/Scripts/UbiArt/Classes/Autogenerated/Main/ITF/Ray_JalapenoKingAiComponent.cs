using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_JalapenoKingAiComponent : CSerializable {
		[Serialize("dead")] public int dead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(dead));
			}
		}
		public override uint? ClassCRC => 0x7E24CD77;
	}
}

