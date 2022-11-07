namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LocalizationConfig_Template : CSerializable {
		public Placeholder locCharacterIDMap;
		public Placeholder characterNames;
		public Placeholder skills;
		public Placeholder levelUpPopUp;
		public Placeholder inventory;
		public Placeholder uplay;
		public Placeholder trc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			locCharacterIDMap = s.SerializeObject<Placeholder>(locCharacterIDMap, name: "locCharacterIDMap");
			characterNames = s.SerializeObject<Placeholder>(characterNames, name: "characterNames");
			skills = s.SerializeObject<Placeholder>(skills, name: "skills");
			levelUpPopUp = s.SerializeObject<Placeholder>(levelUpPopUp, name: "levelUpPopUp");
			inventory = s.SerializeObject<Placeholder>(inventory, name: "inventory");
			uplay = s.SerializeObject<Placeholder>(uplay, name: "uplay");
			trc = s.SerializeObject<Placeholder>(trc, name: "trc");
		}
		public override uint? ClassCRC => 0x5E7FF18D;
	}
}

