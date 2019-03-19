using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_HeartRainComponent_Template : AnimMeshVertexComponent_Template {
		[Serialize("PlanNb"        )] public uint PlanNb;
		[Serialize("PlanTotalDepth")] public float PlanTotalDepth;
		[Serialize("RainLifeTime"  )] public float RainLifeTime;
		[Serialize("HeartNb"       )] public uint HeartNb;
		[Serialize("MinLifeTime"   )] public float MinLifeTime;
		[Serialize("MaxLifeTime"   )] public float MaxLifeTime;
		[Serialize("FallMinSpeed"  )] public float FallMinSpeed;
		[Serialize("FallMaxSpeed"  )] public float FallMaxSpeed;
		[Serialize("FadeMinTimer"  )] public float FadeMinTimer;
		[Serialize("FadeMaxTimer"  )] public float FadeMaxTimer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(PlanNb));
			SerializeField(s, nameof(PlanTotalDepth));
			SerializeField(s, nameof(RainLifeTime));
			SerializeField(s, nameof(HeartNb));
			SerializeField(s, nameof(MinLifeTime));
			SerializeField(s, nameof(MaxLifeTime));
			SerializeField(s, nameof(FallMinSpeed));
			SerializeField(s, nameof(FallMaxSpeed));
			SerializeField(s, nameof(FadeMinTimer));
			SerializeField(s, nameof(FadeMaxTimer));
		}
		public override uint? ClassCRC => 0xED44D885;
	}
}

