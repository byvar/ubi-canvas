using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_WorldMap : CSerializable {
		[Serialize("worldsInfo"     )] public CMap<StringID, WorldInfo> worldsInfo;
		[Serialize("currentWorld"   )] public ObjectPath currentWorld;
		[Serialize("currentWorldTag")] public StringID currentWorldTag;
		[Serialize("currentLevel"   )] public ObjectPath currentLevel;
		[Serialize("currentLevelTag")] public StringID currentLevelTag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(worldsInfo));
			SerializeField(s, nameof(currentWorld));
			SerializeField(s, nameof(currentWorldTag));
			SerializeField(s, nameof(currentLevel));
			SerializeField(s, nameof(currentLevelTag));
		}
		
		[Games(GameFlags.RO)]
		public partial class WorldInfo : CSerializable {
			[Serialize("state"     )] public SPOT_STATE state;
			[Serialize("hasWarning")] public bool hasWarning;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(state));
				SerializeField(s, nameof(hasWarning));
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