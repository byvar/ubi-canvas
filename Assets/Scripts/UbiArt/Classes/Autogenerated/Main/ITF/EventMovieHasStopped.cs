using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventMovieHasStopped : Event {
		public bool endOfMovieReached;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			endOfMovieReached = s.Serialize<bool>(endOfMovieReached, name: "endOfMovieReached");
		}
		public override uint? ClassCRC => 0x14B285CC;
	}
}

