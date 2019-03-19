using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BubbleComponent_Template : ActorComponent_Template {
		[Serialize("SurfaceNodeNb"          )] public uint SurfaceNodeNb;
		[Serialize("BubbleRadius"           )] public float BubbleRadius;
		[Serialize("SoftnessNodeCoeff"      )] public float SoftnessNodeCoeff;
		[Serialize("AngleClampingCoeff"     )] public float AngleClampingCoeff;
		[Serialize("VolumeConservationCoeff")] public float VolumeConservationCoeff;
		[Serialize("CenterForceCoeff"       )] public float CenterForceCoeff;
		[Serialize("NodeRadius"             )] public float NodeRadius;
		[Serialize("CenterRadius"           )] public float CenterRadius;
		[Serialize("NodeWeight"             )] public float NodeWeight;
		[Serialize("ForceFriction"          )] public float ForceFriction;
		[Serialize("Display"                )] public bool Display;
		[Serialize("IsControlled"           )] public bool IsControlled;
		[Serialize("ControlPoint"           )] public bool ControlPoint;
		[Serialize("ForceScaleCoeff"        )] public float ForceScaleCoeff;
		[Serialize("WindForceAngle"         )] public Angle WindForceAngle;
		[Serialize("BezierIter"             )] public uint BezierIter;
		[Serialize("Path"                   )] public Path Path;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(SurfaceNodeNb));
			SerializeField(s, nameof(BubbleRadius));
			SerializeField(s, nameof(SoftnessNodeCoeff));
			SerializeField(s, nameof(AngleClampingCoeff));
			SerializeField(s, nameof(VolumeConservationCoeff));
			SerializeField(s, nameof(CenterForceCoeff));
			SerializeField(s, nameof(NodeRadius));
			SerializeField(s, nameof(CenterRadius));
			SerializeField(s, nameof(NodeWeight));
			SerializeField(s, nameof(ForceFriction));
			SerializeField(s, nameof(Display));
			SerializeField(s, nameof(IsControlled));
			SerializeField(s, nameof(ControlPoint));
			SerializeField(s, nameof(ForceScaleCoeff));
			SerializeField(s, nameof(WindForceAngle));
			SerializeField(s, nameof(BezierIter));
			SerializeField(s, nameof(Path));
		}
		public override uint? ClassCRC => 0x438284B9;
	}
}

