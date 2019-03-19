using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MoviePlayerComponent_Template : MoviePlayerComponent_Template {
		[Serialize("videolist"               )] public Placeholder videolist;
		[Serialize("startTime"               )] public float startTime;
		[Serialize("timeToWaitBetweenMovies" )] public float timeToWaitBetweenMovies;
		[Serialize("canSkipMovie"            )] public int canSkipMovie;
		[Serialize("timeToWaitBeforeSkipping")] public float timeToWaitBeforeSkipping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(videolist));
			SerializeField(s, nameof(startTime));
			SerializeField(s, nameof(timeToWaitBetweenMovies));
			SerializeField(s, nameof(canSkipMovie));
			SerializeField(s, nameof(timeToWaitBeforeSkipping));
		}
		public override uint? ClassCRC => 0x1E5C9873;
	}
}

