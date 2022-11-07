namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepDelay_Template : CSerializable {
		public float time;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			time = s.Serialize<float>(time, name: "time");
		}
		public override uint? ClassCRC => 0xE006F18E;
	}
}

