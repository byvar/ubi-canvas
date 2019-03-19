using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EnemyBullet_Template : RO2_BasicBullet_Template {
		[Serialize("animImpactEnemy"      )] public StringID animImpactEnemy;
		[Serialize("animImpactEnvironment")] public StringID animImpactEnvironment;
		[Serialize("fxExplodeActor"       )] public Path fxExplodeActor;
		[Serialize("gravityExpulse"       )] public float gravityExpulse;
		[Serialize("timeExpulse"          )] public float timeExpulse;
		[Serialize("sparklesFXName"       )] public StringID sparklesFXName;
		[Serialize("impacFXName"          )] public StringID impacFXName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animImpactEnemy));
			SerializeField(s, nameof(animImpactEnvironment));
			SerializeField(s, nameof(fxExplodeActor));
			SerializeField(s, nameof(gravityExpulse));
			SerializeField(s, nameof(timeExpulse));
			SerializeField(s, nameof(sparklesFXName));
			SerializeField(s, nameof(impacFXName));
		}
		public override uint? ClassCRC => 0x0E0F85EB;
	}
}

