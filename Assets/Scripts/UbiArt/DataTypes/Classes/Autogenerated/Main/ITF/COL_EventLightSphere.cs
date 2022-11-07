namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventLightSphere : Event {
		public int active;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			active = s.Serialize<int>(active, name: "active");
		}
		public override uint? ClassCRC => 0xCB943130;
	}
}

