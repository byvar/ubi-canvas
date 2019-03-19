using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleVisualManagerComponent : CSerializable {
		[Serialize("frontResolverId"     )] public Placeholder frontResolverId;
		[Serialize("initialStateColor"   )] public Color initialStateColor;
		[Serialize("idleStateColor"      )] public Color idleStateColor;
		[Serialize("selectionStateColor" )] public Color selectionStateColor;
		[Serialize("actionStateColor"    )] public Color actionStateColor;
		[Serialize("idleToSelectDuration")] public float idleToSelectDuration;
		[Serialize("idleToActionDuration")] public float idleToActionDuration;
		[Serialize("selectToIdleDuration")] public float selectToIdleDuration;
		[Serialize("actionToIdleDuration")] public float actionToIdleDuration;
		[Serialize("transitionCurve"     )] public Placeholder transitionCurve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(frontResolverId));
			SerializeField(s, nameof(initialStateColor));
			SerializeField(s, nameof(idleStateColor));
			SerializeField(s, nameof(selectionStateColor));
			SerializeField(s, nameof(actionStateColor));
			SerializeField(s, nameof(idleToSelectDuration));
			SerializeField(s, nameof(idleToActionDuration));
			SerializeField(s, nameof(selectToIdleDuration));
			SerializeField(s, nameof(actionToIdleDuration));
			SerializeField(s, nameof(transitionCurve));
		}
		public override uint? ClassCRC => 0x2C3BBFD4;
	}
}

