namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionStepWaitInteract : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA7AE8EFC;
	}
}

