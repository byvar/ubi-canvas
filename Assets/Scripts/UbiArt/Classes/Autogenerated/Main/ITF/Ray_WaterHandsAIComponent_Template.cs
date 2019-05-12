using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WaterHandsAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("enemyDetectionRange"   )] public AABB enemyDetectionRange;
		[Serialize("spawnHandPath"         )] public Path spawnHandPath;
		[Serialize("speedAttack"           )] public float speedAttack;
		[Serialize("speedReturn"           )] public float speedReturn;
		[Serialize("timeWaitOnPlayerEscape")] public float timeWaitOnPlayerEscape;
		[Serialize("timeWaitAfterCaught"   )] public float timeWaitAfterCaught;
		[Serialize("timeAnticip"           )] public float timeAnticip;
		[Serialize("useRadiusMaxAttack"    )] public int useRadiusMaxAttack;
		[Serialize("linearMode"            )] public int linearMode;
		[Serialize("distMaxCharge"         )] public float distMaxCharge;
		[Serialize("randomHands"           )] public int randomHands;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
			SerializeField(s, nameof(spawnHandPath));
			SerializeField(s, nameof(speedAttack));
			SerializeField(s, nameof(speedReturn));
			SerializeField(s, nameof(timeWaitOnPlayerEscape));
			SerializeField(s, nameof(timeWaitAfterCaught));
			SerializeField(s, nameof(timeAnticip));
			SerializeField(s, nameof(useRadiusMaxAttack));
			SerializeField(s, nameof(linearMode));
			SerializeField(s, nameof(distMaxCharge));
			SerializeField(s, nameof(randomHands));
		}
		public override uint? ClassCRC => 0x0EDB7ED5;
	}
}

