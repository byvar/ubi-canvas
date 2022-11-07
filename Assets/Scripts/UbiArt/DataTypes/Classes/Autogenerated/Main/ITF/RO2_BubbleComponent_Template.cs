namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BubbleComponent_Template : ActorComponent_Template {
		public uint SurfaceNodeNb;
		public float BubbleRadius;
		public float SoftnessNodeCoeff;
		public float AngleClampingCoeff;
		public float VolumeConservationCoeff;
		public float CenterForceCoeff;
		public float NodeRadius;
		public float CenterRadius;
		public float NodeWeight;
		public float ForceFriction;
		public bool Display;
		public bool IsControlled;
		public bool ControlPoint;
		public float ForceScaleCoeff;
		public Angle WindForceAngle;
		public uint BezierIter;
		public Path Path;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SurfaceNodeNb = s.Serialize<uint>(SurfaceNodeNb, name: "SurfaceNodeNb");
			BubbleRadius = s.Serialize<float>(BubbleRadius, name: "BubbleRadius");
			SoftnessNodeCoeff = s.Serialize<float>(SoftnessNodeCoeff, name: "SoftnessNodeCoeff");
			AngleClampingCoeff = s.Serialize<float>(AngleClampingCoeff, name: "AngleClampingCoeff");
			VolumeConservationCoeff = s.Serialize<float>(VolumeConservationCoeff, name: "VolumeConservationCoeff");
			CenterForceCoeff = s.Serialize<float>(CenterForceCoeff, name: "CenterForceCoeff");
			NodeRadius = s.Serialize<float>(NodeRadius, name: "NodeRadius");
			CenterRadius = s.Serialize<float>(CenterRadius, name: "CenterRadius");
			NodeWeight = s.Serialize<float>(NodeWeight, name: "NodeWeight");
			ForceFriction = s.Serialize<float>(ForceFriction, name: "ForceFriction");
			Display = s.Serialize<bool>(Display, name: "Display");
			IsControlled = s.Serialize<bool>(IsControlled, name: "IsControlled");
			ControlPoint = s.Serialize<bool>(ControlPoint, name: "ControlPoint");
			ForceScaleCoeff = s.Serialize<float>(ForceScaleCoeff, name: "ForceScaleCoeff");
			WindForceAngle = s.SerializeObject<Angle>(WindForceAngle, name: "WindForceAngle");
			BezierIter = s.Serialize<uint>(BezierIter, name: "BezierIter");
			Path = s.SerializeObject<Path>(Path, name: "Path");
		}
		public override uint? ClassCRC => 0x438284B9;
	}
}

