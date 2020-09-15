using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventFullscreenMovieStart : Event {
		public uint videoIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			videoIndex = s.Serialize<uint>(videoIndex, name: "videoIndex");
		}
		public override uint? ClassCRC => 0x3E478ACC;
	}
}

