namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeMailComponent_Template : CSerializable {
		public float fallSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fallSpeed = s.Serialize<float>(fallSpeed, name: "fallSpeed");
		}
		public override uint? ClassCRC => 0x949CF179;
	}
}

