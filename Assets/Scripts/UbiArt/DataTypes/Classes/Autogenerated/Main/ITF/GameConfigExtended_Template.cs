namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GameConfigExtended_Template : TemplateObj {
		public uint doSomething;
		public CListO<Generic<PlayerIDInfo>> playerIDInfo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			doSomething = s.Serialize<uint>(doSomething, name: "doSomething");
			playerIDInfo = s.SerializeObject<CListO<Generic<PlayerIDInfo>>>(playerIDInfo, name: "playerIDInfo");
		}
		public override uint? ClassCRC => 0x16EDCE2E;
	}
}

