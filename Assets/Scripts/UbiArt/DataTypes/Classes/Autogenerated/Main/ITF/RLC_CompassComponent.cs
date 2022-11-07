namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_CompassComponent : ActorComponent {
		public float maxRange;
		public float hysteresis;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxRange = s.Serialize<float>(maxRange, name: "maxRange");
			hysteresis = s.Serialize<float>(hysteresis, name: "hysteresis");
		}
		public override uint? ClassCRC => 0xF3D118E2;
	}
}

