namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class WwiseInputDesc : CSerializable {
		public StringID name;
		public StringID WwiseRtpcGUID;
		public bool IsLocal;
		public AUDIO_RTPC RtpcType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			WwiseRtpcGUID = s.SerializeObject<StringID>(WwiseRtpcGUID, name: "WwiseRtpcGUID");
			IsLocal = s.Serialize<bool>(IsLocal, name: "IsLocal");
			RtpcType = s.Serialize<AUDIO_RTPC>(RtpcType, name: "RtpcType");
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

