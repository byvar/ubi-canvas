namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_InvasionEnemyComponent_Template : CSerializable {
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

