using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SinkingPlatformComponent_Template : ActorComponent_Template {
		public float weightStep;
		public float factor;
		public float stepMultiplier;
		public float maxDistance;
		public float restorationFactor;
		public StringID waterInfluenceBone;
		public StringID sinkFx;
		public StringID floatFx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			weightStep = s.Serialize<float>(weightStep, name: "weightStep");
			factor = s.Serialize<float>(factor, name: "factor");
			stepMultiplier = s.Serialize<float>(stepMultiplier, name: "stepMultiplier");
			maxDistance = s.Serialize<float>(maxDistance, name: "maxDistance");
			restorationFactor = s.Serialize<float>(restorationFactor, name: "restorationFactor");
			waterInfluenceBone = s.SerializeObject<StringID>(waterInfluenceBone, name: "waterInfluenceBone");
			sinkFx = s.SerializeObject<StringID>(sinkFx, name: "sinkFx");
			floatFx = s.SerializeObject<StringID>(floatFx, name: "floatFx");
		}
		public override uint? ClassCRC => 0x023A3DDB;
	}
}

