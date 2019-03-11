using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SwingComponent_Template : CSerializable {
		[Serialize("length"                  )] public float length;
		[Serialize("angle"                   )] public Angle angle;
		[Serialize("gravityMultiplier"       )] public float gravityMultiplier;
		[Serialize("memoryTimer"             )] public float memoryTimer;
		[Serialize("playerDetectRange"       )] public float playerDetectRange;
		[Serialize("armsDistance"            )] public float armsDistance;
		[Serialize("armsLengthStiff"         )] public float armsLengthStiff;
		[Serialize("armsLengthDamp"          )] public float armsLengthDamp;
		[Serialize("armsAngleStiff"          )] public float armsAngleStiff;
		[Serialize("armsAngleDamp"           )] public float armsAngleDamp;
		[Serialize("armsGraspInterpolateTime")] public float armsGraspInterpolateTime;
		[Serialize("numArms"                 )] public uint numArms;
		[Serialize("restAngles"              )] public Placeholder restAngles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(length));
			SerializeField(s, nameof(angle));
			SerializeField(s, nameof(gravityMultiplier));
			SerializeField(s, nameof(memoryTimer));
			SerializeField(s, nameof(playerDetectRange));
			SerializeField(s, nameof(armsDistance));
			SerializeField(s, nameof(armsLengthStiff));
			SerializeField(s, nameof(armsLengthDamp));
			SerializeField(s, nameof(armsAngleStiff));
			SerializeField(s, nameof(armsAngleDamp));
			SerializeField(s, nameof(armsGraspInterpolateTime));
			SerializeField(s, nameof(numArms));
			SerializeField(s, nameof(restAngles));
		}
		public override uint? ClassCRC => 0x0B59F293;
	}
}

