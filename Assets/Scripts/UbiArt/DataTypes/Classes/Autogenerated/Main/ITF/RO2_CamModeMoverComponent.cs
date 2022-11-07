namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CamModeMoverComponent : ActorComponent {
		public float TimeToMove;
		public float BlendCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				TimeToMove = s.Serialize<float>(TimeToMove, name: "TimeToMove");
				BlendCoeff = s.Serialize<float>(BlendCoeff, name: "BlendCoeff");
			}
		}
		public override uint? ClassCRC => 0xD2957F2A;
	}
}

