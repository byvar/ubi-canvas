using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_Level : PersistentGameData_Level {
		public CArrayO<PackedObjectPath> cageMapPassedDoors;
		public uint wonChallenges;
		public SPOT_STATE levelState;
		public uint bestTimeAttack;
		public uint bestLumAttack;
		public bool hasWarning;
		public bool isSkipped;
		public Ray_PersistentGameData_LevelTracking trackingdata;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			cageMapPassedDoors = s.SerializeObject<CArrayO<PackedObjectPath>>(cageMapPassedDoors, name: "cageMapPassedDoors");
			wonChallenges = s.Serialize<uint>(wonChallenges, name: "wonChallenges");
			levelState = s.Serialize<SPOT_STATE>(levelState, name: "levelState");
			bestTimeAttack = s.Serialize<uint>(bestTimeAttack, name: "bestTimeAttack");
			bestLumAttack = s.Serialize<uint>(bestLumAttack, name: "bestLumAttack");
			hasWarning = s.Serialize<bool>(hasWarning, name: "hasWarning");
			isSkipped = s.Serialize<bool>(isSkipped, name: "isSkipped");
			trackingdata = s.SerializeObject<Ray_PersistentGameData_LevelTracking>(trackingdata, name: "trackingdata");
		}
		public enum SPOT_STATE {
			[Serialize("SPOT_STATE_CLOSED"      )] CLOSED = 0,
			[Serialize("SPOT_STATE_NEW"         )] NEW = 1,
			[Serialize("SPOT_STATE_CANNOT_ENTER")] CANNOT_ENTER = 2,
			[Serialize("SPOT_STATE_OPEN"        )] OPEN = 3,
			[Serialize("SPOT_STATE_COMPLETED"   )] COMPLETED = 4,
		}
		public override uint? ClassCRC => 0x8729329A;
	}
}

