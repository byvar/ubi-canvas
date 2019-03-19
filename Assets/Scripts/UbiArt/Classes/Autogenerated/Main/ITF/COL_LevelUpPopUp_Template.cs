using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LevelUpPopUp_Template : CSerializable {
		[Serialize("statNameActorPath"     )] public Path statNameActorPath;
		[Serialize("statValueActorPath"    )] public Path statValueActorPath;
		[Serialize("arrowActorPath"        )] public Path arrowActorPath;
		[Serialize("increaseValueActorPath")] public Path increaseValueActorPath;
		[Serialize("levelIncreasedFX"      )] public StringID levelIncreasedFX;
		[Serialize("skillPointsEarnedFX"   )] public StringID skillPointsEarnedFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(statNameActorPath));
			SerializeField(s, nameof(statValueActorPath));
			SerializeField(s, nameof(arrowActorPath));
			SerializeField(s, nameof(increaseValueActorPath));
			SerializeField(s, nameof(levelIncreasedFX));
			SerializeField(s, nameof(skillPointsEarnedFX));
		}
		public override uint? ClassCRC => 0xAD262E0C;
	}
}

