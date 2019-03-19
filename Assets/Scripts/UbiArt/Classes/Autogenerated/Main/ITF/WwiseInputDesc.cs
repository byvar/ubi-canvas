using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class WwiseInputDesc : CSerializable {
		[Serialize("name"         )] public StringID name;
		[Serialize("WwiseRtpcGUID")] public StringID WwiseRtpcGUID;
		[Serialize("IsLocal"      )] public bool IsLocal;
		[Serialize("RtpcType"     )] public AUDIO_RTPC RtpcType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(WwiseRtpcGUID));
			SerializeField(s, nameof(IsLocal));
			SerializeField(s, nameof(RtpcType));
		}
		public enum AUDIO_RTPC {
			[Serialize("AUDIO_RTPC_LOCAL"                   )] LOCAL = 1,
			[Serialize("AUDIO_RTPC_GLOBAL"                  )] GLOBAL = 0,
			[Serialize("AUDIO_RTPC_SWITCH"                  )] SWITCH = 2,
			[Serialize("AUDIO_RTPC_STATE"                   )] STATE = 3,
			[Serialize("AUDIO_RTPC_DISTANCE_EMITER_LISTENER")] DISTANCE_EMITER_LISTENER = 4,
		}
	}
}

