using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class EventMovieHasStopped : Event {
		[Serialize("endOfMovieReached")] public bool endOfMovieReached;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(endOfMovieReached));
		}
		public override uint? ClassCRC => 0x14B285CC;
	}
}

