using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_465_sub_B91FE0 : CSerializable {
		[Serialize("moveAction"             )] public Placeholder moveAction;
		[Serialize("openingAction"          )] public Placeholder openingAction;
		[Serialize("alarmAction"            )] public Placeholder alarmAction;
		[Serialize("explodeAction"          )] public Placeholder explodeAction;
		[Serialize("alarmAnimName"          )] public StringID alarmAnimName;
		[Serialize("warnAnimName"           )] public StringID warnAnimName;
		[Serialize("alarmDuration"          )] public float alarmDuration;
		[Serialize("isTriggered"            )] public int isTriggered;
		[Serialize("moveActionInitScale"    )] public float moveActionInitScale;
		[Serialize("explodeOnMoveActionsEnd")] public int explodeOnMoveActionsEnd;
		[Serialize("moveActionVecOffsetMin" )] public Vector2 moveActionVecOffsetMin;
		[Serialize("moveActionVecOffsetMax" )] public Vector2 moveActionVecOffsetMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(moveAction));
			SerializeField(s, nameof(openingAction));
			SerializeField(s, nameof(alarmAction));
			SerializeField(s, nameof(explodeAction));
			SerializeField(s, nameof(alarmAnimName));
			SerializeField(s, nameof(warnAnimName));
			SerializeField(s, nameof(alarmDuration));
			SerializeField(s, nameof(isTriggered));
			SerializeField(s, nameof(moveActionInitScale));
			SerializeField(s, nameof(explodeOnMoveActionsEnd));
			SerializeField(s, nameof(moveActionVecOffsetMin));
			SerializeField(s, nameof(moveActionVecOffsetMax));
		}
		public override uint? ClassCRC => 0x74980334;
	}
}

