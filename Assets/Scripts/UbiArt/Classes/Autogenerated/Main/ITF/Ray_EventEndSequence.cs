using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventEndSequence : Event {
		public int playMovie;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playMovie = s.Serialize<int>(playMovie, name: "playMovie");
		}
		public override uint? ClassCRC => 0xEDE8B3A1;
	}
}

