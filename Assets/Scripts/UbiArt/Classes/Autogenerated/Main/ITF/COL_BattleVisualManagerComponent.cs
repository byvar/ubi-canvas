using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleVisualManagerComponent : CSerializable {
		public Placeholder frontResolverId;
		public Color initialStateColor;
		public Color idleStateColor;
		public Color selectionStateColor;
		public Color actionStateColor;
		public float idleToSelectDuration;
		public float idleToActionDuration;
		public float selectToIdleDuration;
		public float actionToIdleDuration;
		public Placeholder transitionCurve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			frontResolverId = s.SerializeObject<Placeholder>(frontResolverId, name: "frontResolverId");
			initialStateColor = s.SerializeObject<Color>(initialStateColor, name: "initialStateColor");
			idleStateColor = s.SerializeObject<Color>(idleStateColor, name: "idleStateColor");
			selectionStateColor = s.SerializeObject<Color>(selectionStateColor, name: "selectionStateColor");
			actionStateColor = s.SerializeObject<Color>(actionStateColor, name: "actionStateColor");
			idleToSelectDuration = s.Serialize<float>(idleToSelectDuration, name: "idleToSelectDuration");
			idleToActionDuration = s.Serialize<float>(idleToActionDuration, name: "idleToActionDuration");
			selectToIdleDuration = s.Serialize<float>(selectToIdleDuration, name: "selectToIdleDuration");
			actionToIdleDuration = s.Serialize<float>(actionToIdleDuration, name: "actionToIdleDuration");
			transitionCurve = s.SerializeObject<Placeholder>(transitionCurve, name: "transitionCurve");
		}
		public override uint? ClassCRC => 0x2C3BBFD4;
	}
}

