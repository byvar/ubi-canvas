using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_EnemyBullet_Template : RO2_BasicBullet_Template {
		public StringID animImpactEnemy;
		public StringID animImpactEnvironment;
		public Path fxExplodeActor;
		public float gravityExpulse;
		public float timeExpulse;
		public StringID sparklesFXName;
		public StringID impacFXName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animImpactEnemy = s.SerializeObject<StringID>(animImpactEnemy, name: "animImpactEnemy");
			animImpactEnvironment = s.SerializeObject<StringID>(animImpactEnvironment, name: "animImpactEnvironment");
			fxExplodeActor = s.SerializeObject<Path>(fxExplodeActor, name: "fxExplodeActor");
			gravityExpulse = s.Serialize<float>(gravityExpulse, name: "gravityExpulse");
			timeExpulse = s.Serialize<float>(timeExpulse, name: "timeExpulse");
			sparklesFXName = s.SerializeObject<StringID>(sparklesFXName, name: "sparklesFXName");
			impacFXName = s.SerializeObject<StringID>(impacFXName, name: "impacFXName");
		}
		public override uint? ClassCRC => 0x0E0F85EB;
	}
}

