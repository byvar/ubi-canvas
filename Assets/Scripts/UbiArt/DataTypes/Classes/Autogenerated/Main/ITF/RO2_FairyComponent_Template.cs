using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_FairyComponent_Template : ActorComponent_Template {
		public float flyDist;
		public float flySpeed;
		public float flyAccelerationMultiplier;
		public float rushDist;
		public float rushSpeed;
		public float rushAccelerationMultiplier;
		public float keepRushTime;
		public bool displayDialogStill;
		public Path lumPath;
		public bool drcSlowEnabled;
		public float drcSlowFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flyDist = s.Serialize<float>(flyDist, name: "flyDist");
			flySpeed = s.Serialize<float>(flySpeed, name: "flySpeed");
			flyAccelerationMultiplier = s.Serialize<float>(flyAccelerationMultiplier, name: "flyAccelerationMultiplier");
			rushDist = s.Serialize<float>(rushDist, name: "rushDist");
			rushSpeed = s.Serialize<float>(rushSpeed, name: "rushSpeed");
			rushAccelerationMultiplier = s.Serialize<float>(rushAccelerationMultiplier, name: "rushAccelerationMultiplier");
			keepRushTime = s.Serialize<float>(keepRushTime, name: "keepRushTime");
			displayDialogStill = s.Serialize<bool>(displayDialogStill, name: "displayDialogStill");
			lumPath = s.SerializeObject<Path>(lumPath, name: "lumPath");
			drcSlowEnabled = s.Serialize<bool>(drcSlowEnabled, name: "drcSlowEnabled");
			drcSlowFactor = s.Serialize<float>(drcSlowFactor, name: "drcSlowFactor");
		}
		public override uint? ClassCRC => 0x87EF869B;
	}
}

