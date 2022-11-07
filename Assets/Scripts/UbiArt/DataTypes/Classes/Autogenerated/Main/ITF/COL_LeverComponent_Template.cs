namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LeverComponent_Template : CSerializable {
		public float animDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animDuration = s.Serialize<float>(animDuration, name: "animDuration");
		}
		public override uint? ClassCRC => 0x14564FFC;
	}
}

