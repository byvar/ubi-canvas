namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepWaitInteract : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCD76195B;
	}
}

