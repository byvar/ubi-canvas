using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_HeartRainComponent_Template : AnimMeshVertexComponent_Template {
		public uint PlanNb;
		public float PlanTotalDepth;
		public float RainLifeTime;
		public uint HeartNb;
		public float MinLifeTime;
		public float MaxLifeTime;
		public float FallMinSpeed;
		public float FallMaxSpeed;
		public float FadeMinTimer;
		public float FadeMaxTimer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			PlanNb = s.Serialize<uint>(PlanNb, name: "PlanNb");
			PlanTotalDepth = s.Serialize<float>(PlanTotalDepth, name: "PlanTotalDepth");
			RainLifeTime = s.Serialize<float>(RainLifeTime, name: "RainLifeTime");
			HeartNb = s.Serialize<uint>(HeartNb, name: "HeartNb");
			MinLifeTime = s.Serialize<float>(MinLifeTime, name: "MinLifeTime");
			MaxLifeTime = s.Serialize<float>(MaxLifeTime, name: "MaxLifeTime");
			FallMinSpeed = s.Serialize<float>(FallMinSpeed, name: "FallMinSpeed");
			FallMaxSpeed = s.Serialize<float>(FallMaxSpeed, name: "FallMaxSpeed");
			FadeMinTimer = s.Serialize<float>(FadeMinTimer, name: "FadeMinTimer");
			FadeMaxTimer = s.Serialize<float>(FadeMaxTimer, name: "FadeMaxTimer");
		}
		public override uint? ClassCRC => 0xED44D885;
	}
}

