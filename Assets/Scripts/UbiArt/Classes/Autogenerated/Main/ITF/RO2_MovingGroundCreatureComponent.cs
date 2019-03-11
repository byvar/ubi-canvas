using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MovingGroundCreatureComponent : ActorComponent {
		[Serialize("ringSide"       )] public SwampRingSide ringSide;
		[Serialize("lianaSide"      )] public SwampRingSide lianaSide;
		[Serialize("isActive"       )] public bool isActive;
		[Serialize("idleStand"      )] public SwampCreatureStand idleStand;
		[Serialize("roamStand"      )] public SwampCreatureStand roamStand;
		[Serialize("isCycle"        )] public bool isCycle;
		[Serialize("waitDuration"   )] public float waitDuration;
		[Serialize("startLeft"      )] public bool startLeft;
		[Serialize("leftStepsCount" )] public int leftStepsCount; // In Legends the next 3 are supposedly bools.
		[Serialize("rightStepsCount")] public int rightStepsCount;
		[Serialize("pendouilleAnim" )] public int pendouilleAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ringSide));
			SerializeField(s, nameof(lianaSide));
			SerializeField(s, nameof(isActive));
			SerializeField(s, nameof(idleStand));
			SerializeField(s, nameof(roamStand));
			SerializeField(s, nameof(isCycle));
			SerializeField(s, nameof(waitDuration));
			SerializeField(s, nameof(startLeft));
			SerializeField(s, nameof(leftStepsCount));
			SerializeField(s, nameof(rightStepsCount));
			SerializeField(s, nameof(pendouilleAnim));
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

