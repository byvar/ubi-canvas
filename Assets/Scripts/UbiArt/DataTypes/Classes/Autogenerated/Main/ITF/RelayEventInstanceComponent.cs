namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class RelayEventInstanceComponent : CSerializable {
		public Placeholder resetEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			resetEvent = s.SerializeObject<Placeholder>(resetEvent, name: "resetEvent");
		}
		public override uint? ClassCRC => 0x02D88068;
	}
}

