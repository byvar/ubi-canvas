using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_TalkingHatAIComponent : CSerializable {
		[Serialize("sentences")] public Placeholder sentences;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(sentences));
			}
		}
		public override uint? ClassCRC => 0xCD01898F;
	}
}

