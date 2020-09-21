using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission : CSerializable {
		public ulong triggersStart;
		public ulong triggersUpdate;
		public ulong triggersCompletion;
		public ulong triggersReset;
		public CArrayP<uint> requiredHitCount;
		public Mission_Difficulty difficulty;
		public Mission_Type objectiveType;
		public Mission_SuccessCondition successCondition;
		public Mission_Class missionClass;
		public StringID id;
		public string debugName;
		public StringID familyId;
		public uint locId;
		public uint titleLocId;
		public CListO<RLC_Mission_Guard> startGuards;
		public CListO<RLC_Mission_Guard> updateGuards;
		public CListO<RLC_Mission_Guard> completionGuards;
		public CListO<RLC_Mission_Guard> resetGuards;
		public bool autoReset;
		public uint missionLevel;
		public StringID missionRewardId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			triggersStart = s.Serialize<ulong>(triggersStart, name: "triggersStart");
			triggersUpdate = s.Serialize<ulong>(triggersUpdate, name: "triggersUpdate");
			triggersCompletion = s.Serialize<ulong>(triggersCompletion, name: "triggersCompletion");
			triggersReset = s.Serialize<ulong>(triggersReset, name: "triggersReset");
			requiredHitCount = s.SerializeObject<CArrayP<uint>>(requiredHitCount, name: "requiredHitCount");
			requiredHitCount = s.SerializeObject<CArrayP<uint>>(requiredHitCount, name: "requiredHitCount");
			difficulty = s.Serialize<Mission_Difficulty>(difficulty, name: "difficulty");
			objectiveType = s.Serialize<Mission_Type>(objectiveType, name: "objectiveType");
			successCondition = s.Serialize<Mission_SuccessCondition>(successCondition, name: "successCondition");
			missionClass = s.Serialize<Mission_Class>(missionClass, name: "missionClass");
			id = s.SerializeObject<StringID>(id, name: "id");
			debugName = s.Serialize<string>(debugName, name: "debugName");
			familyId = s.SerializeObject<StringID>(familyId, name: "familyId");
			locId = s.Serialize<uint>(locId, name: "locId");
			titleLocId = s.Serialize<uint>(titleLocId, name: "titleLocId");
			startGuards = s.SerializeObject<CListO<RLC_Mission_Guard>>(startGuards, name: "startGuards");
			updateGuards = s.SerializeObject<CListO<RLC_Mission_Guard>>(updateGuards, name: "updateGuards");
			completionGuards = s.SerializeObject<CListO<RLC_Mission_Guard>>(completionGuards, name: "completionGuards");
			resetGuards = s.SerializeObject<CListO<RLC_Mission_Guard>>(resetGuards, name: "resetGuards");
			autoReset = s.Serialize<bool>(autoReset, name: "autoReset");
			missionLevel = s.Serialize<uint>(missionLevel, name: "missionLevel");
			missionRewardId = s.SerializeObject<StringID>(missionRewardId, name: "missionRewardId");
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

