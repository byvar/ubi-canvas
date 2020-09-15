using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MusicManager_Template : MusicManager_Template {
		public Path lumMusicManager;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumMusicManager = s.SerializeObject<Path>(lumMusicManager, name: "lumMusicManager");
		}
		public override uint? ClassCRC => 0xE75D7466;
	}
}

