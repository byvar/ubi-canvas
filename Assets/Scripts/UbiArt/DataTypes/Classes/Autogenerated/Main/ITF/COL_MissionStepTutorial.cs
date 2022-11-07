namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionStepTutorial : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD385C324;
	}
}

