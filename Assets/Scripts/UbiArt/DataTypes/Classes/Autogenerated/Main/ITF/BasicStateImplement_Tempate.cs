namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class BasicStateImplement_Tempate : BasicState_Template {
		public StateImplement_Template implementTempate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			implementTempate = s.SerializeObject<StateImplement_Template>(implementTempate, name: "implementTempate");
		}
		public override uint? ClassCRC => 0x8B17155B;
	}
}

