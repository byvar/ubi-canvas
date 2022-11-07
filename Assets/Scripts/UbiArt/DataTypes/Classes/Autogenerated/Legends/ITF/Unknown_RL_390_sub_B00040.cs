namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_390_sub_B00040 : CSerializable {
		public float hideDistance;
		public float waitDistance;
		public float hysteresis;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hideDistance = s.Serialize<float>(hideDistance, name: "hideDistance");
			waitDistance = s.Serialize<float>(waitDistance, name: "waitDistance");
			hysteresis = s.Serialize<float>(hysteresis, name: "hysteresis");
		}
		public override uint? ClassCRC => 0x960CE735;
	}
}

