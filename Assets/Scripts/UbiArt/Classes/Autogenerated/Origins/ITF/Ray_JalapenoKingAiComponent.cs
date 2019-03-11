using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_JalapenoKingAiComponent : CSerializable {
		[Serialize("dead")] public bool dead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(dead));
			}
		}
		public override uint? ClassCRC => 0x7E24CD77;
	}
}

