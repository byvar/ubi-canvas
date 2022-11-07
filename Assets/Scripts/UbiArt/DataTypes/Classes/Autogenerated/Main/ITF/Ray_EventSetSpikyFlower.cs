namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventSetSpikyFlower : Event {
		public uint circleIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			circleIndex = s.Serialize<uint>(circleIndex, name: "circleIndex");
		}
		public override uint? ClassCRC => 0xF688194E;
	}
}

