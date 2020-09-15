using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class WwiseItem : CSerializable {
		public StringID name;
		public StringID GUID;
		public uint ID;
		public AUDIO_ITEM_WWISE Type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			GUID = s.SerializeObject<StringID>(GUID, name: "GUID");
			ID = s.Serialize<uint>(ID, name: "ID");
			Type = s.Serialize<AUDIO_ITEM_WWISE>(Type, name: "Type");
		}
		public enum AUDIO_ITEM_WWISE {
			[Serialize("AUDIO_ITEM_WWISE_EVENT"         )] EVENT = 0,
			[Serialize("AUDIO_ITEM_WWISE_GAME_PARAMETER")] GAME_PARAMETER = 1,
			[Serialize("AUDIO_ITEM_WWISE_STATE_GROUP"   )] STATE_GROUP = 2,
			[Serialize("AUDIO_ITEM_WWISE_STATE"         )] STATE = 3,
			[Serialize("AUDIO_ITEM_WWISE_SWITCH_GROUP"  )] SWITCH_GROUP = 4,
			[Serialize("AUDIO_ITEM_WWISE_SWITCH"        )] SWITCH = 5,
			[Serialize("AUDIO_ITEM_WWISE_TRIGGER"       )] TRIGGER = 6,
			[Serialize("AUDIO_ITEM_WWISE_DIALOGUE_EVENT")] DIALOGUE_EVENT = 7,
		}
	}
}

