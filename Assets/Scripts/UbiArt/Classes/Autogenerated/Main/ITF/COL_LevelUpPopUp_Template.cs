using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LevelUpPopUp_Template : CSerializable {
		public Path statNameActorPath;
		public Path statValueActorPath;
		public Path arrowActorPath;
		public Path increaseValueActorPath;
		public StringID levelIncreasedFX;
		public StringID skillPointsEarnedFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			statNameActorPath = s.SerializeObject<Path>(statNameActorPath, name: "statNameActorPath");
			statValueActorPath = s.SerializeObject<Path>(statValueActorPath, name: "statValueActorPath");
			arrowActorPath = s.SerializeObject<Path>(arrowActorPath, name: "arrowActorPath");
			increaseValueActorPath = s.SerializeObject<Path>(increaseValueActorPath, name: "increaseValueActorPath");
			levelIncreasedFX = s.SerializeObject<StringID>(levelIncreasedFX, name: "levelIncreasedFX");
			skillPointsEarnedFX = s.SerializeObject<StringID>(skillPointsEarnedFX, name: "skillPointsEarnedFX");
		}
		public override uint? ClassCRC => 0xAD262E0C;
	}
}

