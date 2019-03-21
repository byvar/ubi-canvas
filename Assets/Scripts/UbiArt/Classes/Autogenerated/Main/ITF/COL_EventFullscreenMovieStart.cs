using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventFullscreenMovieStart : Event {
		[Serialize("videoIndex")] public uint videoIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(videoIndex));
		}
		public override uint? ClassCRC => 0x3E478ACC;
	}
}

