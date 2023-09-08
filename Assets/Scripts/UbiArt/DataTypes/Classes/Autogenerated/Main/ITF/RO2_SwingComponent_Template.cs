namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SwingComponent_Template : ActorComponent_Template {
		public float length = 1f;
		public Angle angle = 1.570796f;
		public float gravityMultiplier = 1f;
		public float memoryTimer;
		public float playerDetectRange = 5f;
		public float armsDistance = 3f;
		public float armsLengthStiff = 10f;
		public float armsLengthDamp = 1f;
		public float armsAngleStiff = 5f;
		public float armsAngleDamp = 1f;
		public float armsGraspInterpolateTime = 0.1f;
		public uint numArms = 1;
		public CArrayO<Angle> restAngles = new CArrayO<Angle>(new Angle[] { 0.7853982f, 2.356194f, 3.926991f, 5.497787f });
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
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

