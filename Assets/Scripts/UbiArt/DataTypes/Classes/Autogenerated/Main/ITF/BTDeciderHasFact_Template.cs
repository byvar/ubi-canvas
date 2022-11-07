namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class BTDeciderHasFact_Template : BTDecider_Template {
		public CArrayO<StringID> factsHave;
		public CArrayO<StringID> factsNotHave;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factsHave = s.SerializeObject<CArrayO<StringID>>(factsHave, name: "factsHave");
			factsNotHave = s.SerializeObject<CArrayO<StringID>>(factsNotHave, name: "factsNotHave");
		}
		public override uint? ClassCRC => 0x8C782467;
	}
}

