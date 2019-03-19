using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventEndSequence : Event {
		[Serialize("playMovie")] public int playMovie;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playMovie));
		}
		public override uint? ClassCRC => 0xEDE8B3A1;
	}
}

