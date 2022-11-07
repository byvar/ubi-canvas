namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BubblePrizeSpawnerComponent_Template : CSerializable {
		public Path bubblePath;
		public uint bubbleCount;
		public float timeBetweenBubble;
		public int spawnBubbleOnDeath;
		public uint internalRewardNumber;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bubblePath = s.SerializeObject<Path>(bubblePath, name: "bubblePath");
			bubbleCount = s.Serialize<uint>(bubbleCount, name: "bubbleCount");
			timeBetweenBubble = s.Serialize<float>(timeBetweenBubble, name: "timeBetweenBubble");
			spawnBubbleOnDeath = s.Serialize<int>(spawnBubbleOnDeath, name: "spawnBubbleOnDeath");
			internalRewardNumber = s.Serialize<uint>(internalRewardNumber, name: "internalRewardNumber");
		}
		public override uint? ClassCRC => 0x7F0B9BAA;
	}
}

