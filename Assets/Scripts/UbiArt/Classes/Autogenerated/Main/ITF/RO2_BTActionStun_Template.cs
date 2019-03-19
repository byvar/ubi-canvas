using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionStun_Template : BTAction_Template {
		[Serialize("timeBeforeDeath")] public float timeBeforeDeath;
		[Serialize("useDeathTimer"  )] public bool useDeathTimer;
		[Serialize("animStun"       )] public StringID animStun;
		[Serialize("animStunLoop"   )] public StringID animStunLoop;
		[Serialize("animRestor"     )] public StringID animRestor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timeBeforeDeath));
			SerializeField(s, nameof(useDeathTimer));
			SerializeField(s, nameof(animStun));
			SerializeField(s, nameof(animStunLoop));
			SerializeField(s, nameof(animRestor));
		}
		public override uint? ClassCRC => 0x4D831DDD;
	}
}

