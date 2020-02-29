using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_BeatboxData : CSerializable {
		[Serialize("playingtime")] public float playingTime;
		[Serialize("Id"         )] public StringID Id;
		[Serialize("soundId"    )] public StringID soundId;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playingTime));
			SerializeField(s, nameof(Id));
			SerializeField(s, nameof(soundId));
		}
	}
}

