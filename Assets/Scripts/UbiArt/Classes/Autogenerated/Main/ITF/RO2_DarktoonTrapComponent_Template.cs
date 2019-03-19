using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DarktoonTrapComponent_Template : RO2_AIComponent_Template {
		[Serialize("animIdle"    )] public StringID animIdle;
		[Serialize("animAttack"  )] public StringID animAttack;
		[Serialize("animHit"     )] public StringID animHit;
		[Serialize("animFall"    )] public StringID animFall;
		[Serialize("animStun"    )] public StringID animStun;
		[Serialize("stunDuration")] public float stunDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animIdle));
			SerializeField(s, nameof(animAttack));
			SerializeField(s, nameof(animHit));
			SerializeField(s, nameof(animFall));
			SerializeField(s, nameof(animStun));
			SerializeField(s, nameof(stunDuration));
		}
		public override uint? ClassCRC => 0x96259FB4;
	}
}

