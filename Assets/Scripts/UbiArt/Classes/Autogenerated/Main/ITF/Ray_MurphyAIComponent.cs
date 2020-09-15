using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MurphyAIComponent : ActorComponent {
		public CList<LocalisationId> sentences;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				sentences = s.SerializeObject<CList<LocalisationId>>(sentences, name: "sentences");
			}
		}
		public override uint? ClassCRC => 0xF6D9B2D7;
	}
}

