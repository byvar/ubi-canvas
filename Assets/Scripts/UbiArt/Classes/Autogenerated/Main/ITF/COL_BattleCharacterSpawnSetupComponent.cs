using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleCharacterSpawnSetupComponent : CSerializable {
		[Description("Spawn index")]
		[Serialize("spawnIndex"             )] public int spawnIndex;
		[Serialize("spawnFlipped"           )] public bool spawnFlipped;
		[Description("The team of the associated character")]
		[Serialize("teamType"               )] public Enum_teamType teamType;
		[Description("ObjectId of the associated spotlight used for action/target selection")]
		[Serialize("spotlightID"            )] public Placeholder spotlightID;
		[Description("ObjectId of the associated platform intro sequence")]
		[Serialize("platformIntroSequenceID")] public Placeholder platformIntroSequenceID;
		[Description("ObjectId of the associated platform death sequence")]
		[Serialize("platformDeathSequenceID")] public Placeholder platformDeathSequenceID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawnIndex));
			SerializeField(s, nameof(spawnFlipped), boolAsByte: true);
			SerializeField(s, nameof(teamType));
			SerializeField(s, nameof(spotlightID));
			SerializeField(s, nameof(platformIntroSequenceID));
			SerializeField(s, nameof(platformDeathSequenceID));
		}
		public enum Enum_teamType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x3CD40548;
	}
}

