using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MurphyAIComponent : ActorComponent {
		[Serialize("sentences")] public CList<LocalisationId> sentences;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(sentences));
			}
		}
		public override uint? ClassCRC => 0xF6D9B2D7;
	}
}

