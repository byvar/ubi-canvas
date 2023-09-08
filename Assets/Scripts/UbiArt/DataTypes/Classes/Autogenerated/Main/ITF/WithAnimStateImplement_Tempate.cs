namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class WithAnimStateImplement_Tempate : WithAnimState_Template {
		public StateImplement_Template implementTempate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
			} else {
				implementTempate = s.SerializeObject<StateImplement_Template>(implementTempate, name: "implementTempate");
			}
		}
		public override uint? ClassCRC => 0x29C931C9;
	}
}

