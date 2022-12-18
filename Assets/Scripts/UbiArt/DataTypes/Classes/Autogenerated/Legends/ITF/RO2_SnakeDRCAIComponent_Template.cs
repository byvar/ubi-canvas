namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_SnakeDRCAIComponent_Template : CSerializable {
		public float tapAccelerationMultiplier;
		public float gettimePlayRate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tapAccelerationMultiplier = s.Serialize<float>(tapAccelerationMultiplier, name: "tapAccelerationMultiplier");
			gettimePlayRate = s.Serialize<float>(gettimePlayRate, name: "gettimePlayRate");
		}
		public override uint? ClassCRC => 0x38A31802;
	}
}

