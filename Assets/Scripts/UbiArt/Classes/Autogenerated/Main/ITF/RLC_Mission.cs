using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission : CSerializable {
		[Serialize("triggersStart"     )] public ulong triggersStart;
		[Serialize("triggersUpdate"    )] public ulong triggersUpdate;
		[Serialize("triggersCompletion")] public ulong triggersCompletion;
		[Serialize("triggersReset"     )] public ulong triggersReset;
		[Serialize("requiredHitCount"  )] public CArray<uint> requiredHitCount;
		[Serialize("difficulty"        )] public Mission_Difficulty difficulty;
		[Serialize("objectiveType"     )] public Mission_Type objectiveType;
		[Serialize("successCondition"  )] public Mission_SuccessCondition successCondition;
		[Serialize("missionClass"      )] public Mission_Class missionClass;
		[Serialize("id"                )] public StringID id;
		[Serialize("debugName"         )] public string debugName;
		[Serialize("familyId"          )] public StringID familyId;
		[Serialize("locId"             )] public uint locId;
		[Serialize("titleLocId"        )] public uint titleLocId;
		[Serialize("startGuards"       )] public CList<RLC_Mission_Guard> startGuards;
		[Serialize("updateGuards"      )] public CList<RLC_Mission_Guard> updateGuards;
		[Serialize("completionGuards"  )] public CList<RLC_Mission_Guard> completionGuards;
		[Serialize("resetGuards"       )] public CList<RLC_Mission_Guard> resetGuards;
		[Serialize("autoReset"         )] public bool autoReset;
		[Serialize("missionLevel"      )] public uint missionLevel;
		[Serialize("missionRewardId"   )] public StringID missionRewardId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(triggersStart));
			SerializeField(s, nameof(triggersUpdate));
			SerializeField(s, nameof(triggersCompletion));
			SerializeField(s, nameof(triggersReset));
			SerializeField(s, nameof(requiredHitCount));
			SerializeField(s, nameof(requiredHitCount));
			SerializeField(s, nameof(difficulty));
			SerializeField(s, nameof(objectiveType));
			SerializeField(s, nameof(successCondition));
			SerializeField(s, nameof(missionClass));
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(debugName));
			SerializeField(s, nameof(familyId));
			SerializeField(s, nameof(locId));
			SerializeField(s, nameof(titleLocId));
			SerializeField(s, nameof(startGuards));
			SerializeField(s, nameof(updateGuards));
			SerializeField(s, nameof(completionGuards));
			SerializeField(s, nameof(resetGuards));
			SerializeField(s, nameof(autoReset));
			SerializeField(s, nameof(missionLevel));
			SerializeField(s, nameof(missionRewardId));
		}
		public enum Mission_Difficulty {
			[Serialize("Mission_Difficulty::easy"  )] easy = 0,
			[Serialize("Mission_Difficulty::medium")] medium = 1,
			[Serialize("Mission_Difficulty::hard"  )] hard = 2,
		}
		public enum Mission_Type {
			[Serialize("Mission_Type::lums"       )] lums = 0,
			[Serialize("Mission_Type::enemy"      )] enemy = 1,
			[Serialize("Mission_Type::completion" )] completion = 2,
			[Serialize("Mission_Type::exploration")] exploration = 3,
		}
		public enum Mission_SuccessCondition {
			[Serialize("Mission_SuccessCondition::more"  )] more = 0,
			[Serialize("Mission_SuccessCondition::less"  )] less = 1,
			[Serialize("Mission_SuccessCondition::equals")] equals = 2,
		}
		public enum Mission_Class {
			[Serialize("Mission_Class::mission"       )] mission = 0,
			[Serialize("Mission_Class::achievement"   )] achievement = 1,
			[Serialize("Mission_Class::dailyObjective")] dailyObjective = 2,
		}
		public override uint? ClassCRC => 0xDE878F68;
	}
}

