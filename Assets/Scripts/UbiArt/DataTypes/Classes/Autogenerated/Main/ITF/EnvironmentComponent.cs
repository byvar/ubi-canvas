namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class EnvironmentComponent : CSerializable {
		public SoundGUID Environment;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Environment = s.SerializeObject<SoundGUID>(Environment, name: "Environment");
		}
		public override uint? ClassCRC => 0xFD7E5952;
	}
}

