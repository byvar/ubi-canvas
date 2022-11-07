namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CharacterStatsConfig_Template : CSerializable {
		public Placeholder defaultMaxAttributes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			defaultMaxAttributes = s.SerializeObject<Placeholder>(defaultMaxAttributes, name: "defaultMaxAttributes");
		}
		public override uint? ClassCRC => 0x342E9374;
	}
}

