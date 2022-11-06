using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TalkingHatAIComponent : CSerializable {
		public Placeholder sentences;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				sentences = s.SerializeObject<Placeholder>(sentences, name: "sentences");
			}
		}
		public override uint? ClassCRC => 0xCD01898F;
	}
}

