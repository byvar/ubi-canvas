namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GameProgressManager_Template : TemplateObj {
		public CMap<StringID, MapProgressContainer> MapProgressList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			MapProgressList = s.SerializeObject<CMap<StringID, MapProgressContainer>>(MapProgressList, name: "MapProgressList");
		}
		public override uint? ClassCRC => 0x070A52F7;
	}
}

