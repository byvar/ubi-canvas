namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_GameOptionsManager_Template : CSerializable {
		public Placeholder defaultOptions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			defaultOptions = s.SerializeObject<Placeholder>(defaultOptions, name: "defaultOptions");
		}
		public override uint? ClassCRC => 0x3C7BD8C8;
	}
}

