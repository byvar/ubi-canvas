namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class BasicStateMachine_Template : CSerializable {
		public CListO<Generic<BasicState_Template>> stateList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
			} else {
				stateList = s.SerializeObject<CListO<Generic<BasicState_Template>>>(stateList, name: "stateList");
			}
		}
		public override uint? ClassCRC => 0x81FA00D7;
	}
}

