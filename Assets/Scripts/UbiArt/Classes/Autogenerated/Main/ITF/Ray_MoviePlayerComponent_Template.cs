using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MoviePlayerComponent_Template : MoviePlayerComponent_Template {
		public Placeholder videolist;
		public float startTime;
		public float timeToWaitBetweenMovies;
		public int canSkipMovie;
		public float timeToWaitBeforeSkipping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			videolist = s.SerializeObject<Placeholder>(videolist, name: "videolist");
			startTime = s.Serialize<float>(startTime, name: "startTime");
			timeToWaitBetweenMovies = s.Serialize<float>(timeToWaitBetweenMovies, name: "timeToWaitBetweenMovies");
			canSkipMovie = s.Serialize<int>(canSkipMovie, name: "canSkipMovie");
			timeToWaitBeforeSkipping = s.Serialize<float>(timeToWaitBeforeSkipping, name: "timeToWaitBeforeSkipping");
		}
		public override uint? ClassCRC => 0x1E5C9873;
	}
}

