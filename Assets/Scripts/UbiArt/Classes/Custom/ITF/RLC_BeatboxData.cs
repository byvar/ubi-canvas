using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_BeatboxData : CSerializable {
		public float playingtime;
		public StringID Id;
		public StringID soundId;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playingtime = s.Serialize<float>(playingtime, name: "playingtime");
			Id = s.SerializeObject<StringID>(Id, name: "Id");
			soundId = s.SerializeObject<StringID>(soundId, name: "soundId");
		}
	}
}

