using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_69_sub_943E60 : CSerializable {
		[Serialize("musicName"            )] public StringID musicName;
		[Serialize("pauseInsensitiveFlags")] public uint pauseInsensitiveFlags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(pauseInsensitiveFlags));
				SerializeField(s, nameof(musicName));
			} else {
				SerializeField(s, nameof(musicName));
			}
		}
		public override uint? ClassCRC => 0x6818BD48;
	}
}

