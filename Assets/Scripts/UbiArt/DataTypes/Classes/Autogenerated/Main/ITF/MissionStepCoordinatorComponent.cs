namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepCoordinatorComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7A0C4A93;
	}
}

