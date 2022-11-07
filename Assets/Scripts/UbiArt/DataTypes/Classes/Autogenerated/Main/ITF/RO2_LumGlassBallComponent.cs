namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_LumGlassBallComponent : ActorComponent {
		public bool SteadyChildren;
		public float TorqueFriction;
		public float SpeedFriction;
		public EditableShape shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SteadyChildren = s.Serialize<bool>(SteadyChildren, name: "SteadyChildren");
				TorqueFriction = s.Serialize<float>(TorqueFriction, name: "TorqueFriction");
				SpeedFriction = s.Serialize<float>(SpeedFriction, name: "SpeedFriction");
				shape = s.SerializeObject<EditableShape>(shape, name: "shape");
			}
		}
		public override uint? ClassCRC => 0x3D3CA6BF;
	}
}

