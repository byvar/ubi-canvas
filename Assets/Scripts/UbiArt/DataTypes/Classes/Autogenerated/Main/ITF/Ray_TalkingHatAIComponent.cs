namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TalkingHatAIComponent : ActorComponent {
		public CListO<LocalisationId> sentences;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				sentences = s.SerializeObject<CListO<LocalisationId>>(sentences, name: "sentences");
			}
		}
		public override uint? ClassCRC => 0xCD01898F;
	}
}

