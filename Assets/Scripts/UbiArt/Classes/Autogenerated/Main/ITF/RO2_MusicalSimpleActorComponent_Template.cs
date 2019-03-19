using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicalSimpleActorComponent_Template : ActorComponent_Template {
		[Serialize("animationIdle"           )] public StringID animationIdle;
		[Serialize("animationMusical"        )] public StringID animationMusical;
		[Serialize("animationTickle"         )] public StringID animationTickle;
		[Serialize("animationMusicalToTickle")] public StringID animationMusicalToTickle;
		[Serialize("animationTickleToMusical")] public StringID animationTickleToMusical;
		[Serialize("animationMusicalToIdle"  )] public StringID animationMusicalToIdle;
		[Serialize("animationIdleToMusical"  )] public StringID animationIdleToMusical;
		[Serialize("animationIdleToTickle"   )] public StringID animationIdleToTickle;
		[Serialize("animationTickleToIdle"   )] public StringID animationTickleToIdle;
		[Serialize("lumsByReward"            )] public uint lumsByReward;
		[Serialize("countMaxReward"          )] public uint countMaxReward;
		[Serialize("timeBetweenRewardInSwipe")] public float timeBetweenRewardInSwipe;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animationIdle));
			SerializeField(s, nameof(animationMusical));
			SerializeField(s, nameof(animationTickle));
			SerializeField(s, nameof(animationMusicalToTickle));
			SerializeField(s, nameof(animationTickleToMusical));
			SerializeField(s, nameof(animationMusicalToIdle));
			SerializeField(s, nameof(animationIdleToMusical));
			SerializeField(s, nameof(animationIdleToTickle));
			SerializeField(s, nameof(animationTickleToIdle));
			SerializeField(s, nameof(lumsByReward));
			SerializeField(s, nameof(countMaxReward));
			SerializeField(s, nameof(timeBetweenRewardInSwipe));
		}
		public override uint? ClassCRC => 0xC8F79971;
	}
}

