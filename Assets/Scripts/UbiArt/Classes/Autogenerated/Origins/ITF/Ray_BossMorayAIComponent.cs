using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BossMorayAIComponent : Ray_SnakeAIComponent {
		[Serialize("sequences"     )] public Placeholder sequences;
		[Serialize("finalCinematic")] public ObjectPath finalCinematic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(sequences));
				SerializeField(s, nameof(finalCinematic));
			}
		}
		public override uint? ClassCRC => 0x79F06CB0;
	}
}

