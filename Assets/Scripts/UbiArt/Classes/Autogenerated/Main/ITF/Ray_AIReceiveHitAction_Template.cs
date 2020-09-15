using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIReceiveHitAction_Template : AIReceiveHitAction_Template {
		public Generic<Ray_EventSpawnReward> reward;
		public float playRateVariation;
		public int faceHitDir;
		public int ignoreWind;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			reward = s.SerializeObject<Generic<Ray_EventSpawnReward>>(reward, name: "reward");
			playRateVariation = s.Serialize<float>(playRateVariation, name: "playRateVariation");
			faceHitDir = s.Serialize<int>(faceHitDir, name: "faceHitDir");
			ignoreWind = s.Serialize<int>(ignoreWind, name: "ignoreWind");
		}
		public override uint? ClassCRC => 0x18FA8506;
	}
}

