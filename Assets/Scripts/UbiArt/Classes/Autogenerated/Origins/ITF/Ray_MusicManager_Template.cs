using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_MusicManager_Template : MusicManager_Template {
		[Serialize("lumMusicManager")] public Path lumMusicManager;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lumMusicManager));
		}
		public override uint? ClassCRC => 0xE75D7466;
	}
}

