namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class AIPlayFXAction_Template : AIAction_Template {
		public StringID fxName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fxName = s.SerializeObject<StringID>(fxName, name: "fxName");
		}
		public override uint? ClassCRC => 0xDA3E6266;
	}
}

