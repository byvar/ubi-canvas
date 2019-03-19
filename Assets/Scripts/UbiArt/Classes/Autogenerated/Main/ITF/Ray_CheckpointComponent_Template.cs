using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_CheckpointComponent_Template : CheckpointComponent_Template {
		[Serialize("Sequence"        )] public Path Sequence;
		[Serialize("commitGameState" )] public int commitGameState;
		[Serialize("waitTime"        )] public float waitTime;
		[Serialize("timeBetweenRank" )] public float timeBetweenRank;
		[Serialize("displayScoreTime")] public float displayScoreTime;
		[Serialize("startAnimations" )] public Placeholder startAnimations;
		[Serialize("animationsByRank")] public Placeholder animationsByRank;
		[Serialize("boneNamesByRank" )] public Placeholder boneNamesByRank;
		[Serialize("fakePlayers"     )] public Placeholder fakePlayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Sequence));
			SerializeField(s, nameof(commitGameState));
			SerializeField(s, nameof(waitTime));
			SerializeField(s, nameof(timeBetweenRank));
			SerializeField(s, nameof(displayScoreTime));
			SerializeField(s, nameof(startAnimations));
			SerializeField(s, nameof(animationsByRank));
			SerializeField(s, nameof(boneNamesByRank));
			SerializeField(s, nameof(fakePlayers));
		}
		public override uint? ClassCRC => 0x4C452AEC;
	}
}

