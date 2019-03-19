using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FullscreenMoviePlayerComponent : CSerializable {
		[Serialize("videoIndex")] public uint videoIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(videoIndex));
		}
		public override uint? ClassCRC => 0xE6C041D1;
	}
}

