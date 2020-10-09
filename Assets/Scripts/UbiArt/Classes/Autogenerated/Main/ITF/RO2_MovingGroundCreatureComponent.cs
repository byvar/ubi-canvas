using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MovingGroundCreatureComponent : ActorComponent {
		public SwampRingSide ringSide;
		public SwampRingSide lianaSide;
		public bool isActive;
		public SwampCreatureStand idleStand;
		public SwampCreatureStand roamStand;
		public bool isCycle;
		public float waitDuration;
		public bool startLeft;
		public int leftStepsCount;
		public int rightStepsCount;
		public int pendouilleAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				ringSide = s.Serialize<SwampRingSide>(ringSide, name: "ringSide");
				lianaSide = s.Serialize<SwampRingSide>(lianaSide, name: "lianaSide");
				isActive = s.Serialize<bool>(isActive, name: "isActive");
				idleStand = s.Serialize<SwampCreatureStand>(idleStand, name: "idleStand");
				roamStand = s.Serialize<SwampCreatureStand>(roamStand, name: "roamStand");
				isCycle = s.Serialize<bool>(isCycle, name: "isCycle");
				waitDuration = s.Serialize<float>(waitDuration, name: "waitDuration");
				startLeft = s.Serialize<bool>(startLeft, name: "startLeft");
				leftStepsCount = s.Serialize<int>(leftStepsCount, name: "leftStepsCount");
				rightStepsCount = s.Serialize<int>(rightStepsCount, name: "rightStepsCount");
				pendouilleAnim = s.Serialize<int>(pendouilleAnim, name: "pendouilleAnim");
			} else {
				ringSide = s.Serialize<SwampRingSide>(ringSide, name: "ringSide");
				lianaSide = s.Serialize<SwampRingSide>(lianaSide, name: "lianaSide");
				isActive = s.Serialize<bool>(isActive, name: "isActive");
				idleStand = s.Serialize<SwampCreatureStand>(idleStand, name: "idleStand");
				roamStand = s.Serialize<SwampCreatureStand>(roamStand, name: "roamStand");
				isCycle = s.Serialize<bool>(isCycle, name: "isCycle");
				waitDuration = s.Serialize<float>(waitDuration, name: "waitDuration");
				startLeft = s.Serialize<bool>(startLeft, name: "startLeft");
				leftStepsCount = s.Serialize<int>(leftStepsCount, name: "leftStepsCount");
				rightStepsCount = s.Serialize<int>(rightStepsCount, name: "rightStepsCount");
				pendouilleAnim = s.Serialize<int>(pendouilleAnim, name: "pendouilleAnim");
			}
		}
		public enum SwampRingSide {
			[Serialize("SwampRingSide_None"        )] None = 0,
			[Serialize("SwampRingSide_LeftAndRight")] LeftAndRight = 3,
			[Serialize("SwampRingSide_Left"        )] Left = 1,
			[Serialize("SwampRingSide_Right"       )] Right = 2,
		}
		public enum SwampCreatureStand {
			[Serialize("SwampCreatureStand_Down"  )] Down = 1,
			[Serialize("SwampCreatureStand_Middle")] Middle = 2,
			[Serialize("SwampCreatureStand_Up"    )] Up = 3,
		}
		public override uint? ClassCRC => 0x4839A19F;
	}
}

