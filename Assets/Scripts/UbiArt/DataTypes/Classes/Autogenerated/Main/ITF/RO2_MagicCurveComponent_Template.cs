namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_MagicCurveComponent_Template : ActorComponent_Template {
		public BezierCurveRenderer_Template bezierRenderer;
		public bool debug;
		public bool useOrientation;
		public float distMin;
		public float uvScrollFactor;
		public float extraLength;
		public Vec2d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bezierRenderer = s.SerializeObject<BezierCurveRenderer_Template>(bezierRenderer, name: "bezierRenderer");
			debug = s.Serialize<bool>(debug, name: "debug");
			useOrientation = s.Serialize<bool>(useOrientation, name: "useOrientation");
			distMin = s.Serialize<float>(distMin, name: "distMin");
			uvScrollFactor = s.Serialize<float>(uvScrollFactor, name: "uvScrollFactor");
			extraLength = s.Serialize<float>(extraLength, name: "extraLength");
			offset = s.SerializeObject<Vec2d>(offset, name: "offset");
		}
		public override uint? ClassCRC => 0xCC65456C;
	}
}

