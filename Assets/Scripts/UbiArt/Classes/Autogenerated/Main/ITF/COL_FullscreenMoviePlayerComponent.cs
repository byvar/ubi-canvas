using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FullscreenMoviePlayerComponent : CSerializable {
		public uint videoIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			videoIndex = s.Serialize<uint>(videoIndex, name: "videoIndex");
		}
		public override uint? ClassCRC => 0xAEBAC8E5;
	}
}

