namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionActivateActor : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAB0A8046;
	}
}

