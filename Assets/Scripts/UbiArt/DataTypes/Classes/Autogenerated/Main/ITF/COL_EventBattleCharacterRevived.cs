namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventBattleCharacterRevived : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEECF97A3;
	}
}

