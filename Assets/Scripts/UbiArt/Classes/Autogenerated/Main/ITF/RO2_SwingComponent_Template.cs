using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SwingComponent_Template : ActorComponent_Template {
		public float length;
		public Angle angle;
		public float gravityMultiplier;
		public float memoryTimer;
		public float playerDetectRange;
		public float armsDistance;
		public float armsLengthStiff;
		public float armsLengthDamp;
		public float armsAngleStiff;
		public float armsAngleDamp;
		public float armsGraspInterpolateTime;
		public uint numArms;
		public CArrayO<Angle> restAngles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				length = s.Serialize<float>(length, name: "length");
				angle = s.SerializeObject<Angle>(angle, name: "angle");
				gravityMultiplier = s.Serialize<float>(gravityMultiplier, name: "gravityMultiplier");
				memoryTimer = s.Serialize<float>(memoryTimer, name: "memoryTimer");
				playerDetectRange = s.Serialize<float>(playerDetectRange, name: "playerDetectRange");
				armsDistance = s.Serialize<float>(armsDistance, name: "armsDistance");
				armsLengthStiff = s.Serialize<float>(armsLengthStiff, name: "armsLengthStiff");
				armsLengthDamp = s.Serialize<float>(armsLengthDamp, name: "armsLengthDamp");
				armsAngleStiff = s.Serialize<float>(armsAngleStiff, name: "armsAngleStiff");
				armsAngleDamp = s.Serialize<float>(armsAngleDamp, name: "armsAngleDamp");
				armsGraspInterpolateTime = s.Serialize<float>(armsGraspInterpolateTime, name: "armsGraspInterpolateTime");
				numArms = s.Serialize<uint>(numArms, name: "numArms");
				restAngles = s.SerializeObject<CArrayO<Angle>>(restAngles, name: "restAngles");
			} else {
				length = s.Serialize<float>(length, name: "length");
				angle = s.SerializeObject<Angle>(angle, name: "angle");
				gravityMultiplier = s.Serialize<float>(gravityMultiplier, name: "gravityMultiplier");
				memoryTimer = s.Serialize<float>(memoryTimer, name: "memoryTimer");
				playerDetectRange = s.Serialize<float>(playerDetectRange, name: "playerDetectRange");
				armsDistance = s.Serialize<float>(armsDistance, name: "armsDistance");
				armsLengthStiff = s.Serialize<float>(armsLengthStiff, name: "armsLengthStiff");
				armsLengthDamp = s.Serialize<float>(armsLengthDamp, name: "armsLengthDamp");
				armsAngleStiff = s.Serialize<float>(armsAngleStiff, name: "armsAngleStiff");
				armsAngleDamp = s.Serialize<float>(armsAngleDamp, name: "armsAngleDamp");
				armsGraspInterpolateTime = s.Serialize<float>(armsGraspInterpolateTime, name: "armsGraspInterpolateTime");
				numArms = s.Serialize<uint>(numArms, name: "numArms");
				restAngles = s.SerializeObject<CArrayO<Angle>>(restAngles, name: "restAngles");
				restAngles = s.SerializeObject<CArrayO<Angle>>(restAngles, name: "restAngles");
			}
		}
		public override uint? ClassCRC => 0x69030175;
	}
}

