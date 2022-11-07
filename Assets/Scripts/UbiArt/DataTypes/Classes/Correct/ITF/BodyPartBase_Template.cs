namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class BodyPartBase_Template : CSerializable {
		public float lengthOnTrajectory;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lengthOnTrajectory = s.Serialize<float>(lengthOnTrajectory, name: "lengthOnTrajectory");
		}
		public override uint? ClassCRC => 0x8FD535C3;
	}
}

