using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_WorldMap : CSerializable {
		public CMap<StringID, WorldInfo> worldsInfo;
		public ObjectPath currentWorld;
		public StringID currentWorldTag;
		public ObjectPath currentLevel;
		public StringID currentLevelTag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			worldsInfo = s.SerializeObject<CMap<StringID, WorldInfo>>(worldsInfo, name: "worldsInfo");
			currentWorld = s.SerializeObject<ObjectPath>(currentWorld, name: "currentWorld");
			currentWorldTag = s.SerializeObject<StringID>(currentWorldTag, name: "currentWorldTag");
			currentLevel = s.SerializeObject<ObjectPath>(currentLevel, name: "currentLevel");
			currentLevelTag = s.SerializeObject<StringID>(currentLevelTag, name: "currentLevelTag");
		}
		
		[Games(GameFlags.RO)]
		public partial class WorldInfo : CSerializable {
			public SPOT_STATE state;
			public bool hasWarning;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				state = s.Serialize<SPOT_STATE>(state, name: "state");
				hasWarning = s.Serialize<bool>(hasWarning, name: "hasWarning");
			}
			public enum SPOT_STATE {
				[Serialize("SPOT_STATE_CLOSED"      )] CLOSED = 0,
				[Serialize("SPOT_STATE_NEW"         )] NEW = 1,
				[Serialize("SPOT_STATE_CANNOT_ENTER")] CANNOT_ENTER = 2,
				[Serialize("SPOT_STATE_OPEN"        )] OPEN = 3,
				[Serialize("SPOT_STATE_COMPLETED"   )] COMPLETED = 4,
			}
		}
	}
}
