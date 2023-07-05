namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_CreditsManagerAIComponent_Template : Ray_AIComponent_Template {
		public CListO<CreditsLine> creditsList;
		public Path gmatPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			creditsList = s.SerializeObject<CListO<CreditsLine>>(creditsList, name: "creditsList");
			gmatPath = s.SerializeObject<Path>(gmatPath, name: "gmatPath");
		}
		public override uint? ClassCRC => 0x94865FFC;
	}
}

