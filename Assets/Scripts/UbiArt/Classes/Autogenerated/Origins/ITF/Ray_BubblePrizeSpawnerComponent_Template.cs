using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BubblePrizeSpawnerComponent_Template : CSerializable {
		[Serialize("bubblePath"          )] public Path bubblePath;
		[Serialize("bubbleCount"         )] public uint bubbleCount;
		[Serialize("timeBetweenBubble"   )] public float timeBetweenBubble;
		[Serialize("spawnBubbleOnDeath"  )] public bool spawnBubbleOnDeath;
		[Serialize("internalRewardNumber")] public uint internalRewardNumber;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bubblePath));
			SerializeField(s, nameof(bubbleCount));
			SerializeField(s, nameof(timeBetweenBubble));
			SerializeField(s, nameof(spawnBubbleOnDeath));
			SerializeField(s, nameof(internalRewardNumber));
		}
		public override uint? ClassCRC => 0x7F0B9BAA;
	}
}

