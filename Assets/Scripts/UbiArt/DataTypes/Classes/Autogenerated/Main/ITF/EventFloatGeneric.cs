namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventFloatGeneric : EventGeneric {
		public float Float;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Float = s.Serialize<float>(Float, name: "Float");
		}
		public override uint? ClassCRC => 0x00A70CCE;
	}
}

