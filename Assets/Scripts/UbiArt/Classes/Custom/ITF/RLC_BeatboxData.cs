using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_BeatboxData : CSerializable {
		public float playingTime;
		public StringID Id;
		public StringID soundId;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playingTime = s.Serialize<float>(playingTime, name: "playingTime");
			Id = s.SerializeObject<StringID>(Id, name: "Id");
			soundId = s.SerializeObject<StringID>(soundId, name: "soundId");
		}
	}
}

