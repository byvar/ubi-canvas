using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventForcePlayerAction : Event {
		[Serialize("action"      )] public PlayerForcedAction action;
		[Serialize("enable"      )] public bool enable;
		[Serialize("direction"   )] public Vector2 direction;
		[Serialize("hold"        )] public bool hold;
		[Serialize("waitDuration")] public float waitDuration;
		[Serialize("sprint"      )] public bool sprint;
		[Serialize("priority"    )] public uint priority;
		[Serialize("action"      )] public Enum_action action;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(action));
				SerializeField(s, nameof(enable));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(hold));
				SerializeField(s, nameof(waitDuration));
				SerializeField(s, nameof(sprint));
				SerializeField(s, nameof(priority));
			} else {
				SerializeField(s, nameof(action));
				SerializeField(s, nameof(enable));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(hold));
				SerializeField(s, nameof(waitDuration));
				SerializeField(s, nameof(sprint));
				SerializeField(s, nameof(priority));
			}
		}
		public enum PlayerForcedAction {
			[Serialize("PlayerForcedAction_None"  )] None = 0,
			[Serialize("PlayerForcedAction_Walk"  )] Walk = 1,
			[Serialize("PlayerForcedAction_Jump"  )] Jump = 2,
			[Serialize("PlayerForcedAction_Helico")] Helico = 3,
			[Serialize("PlayerForcedAction_Attack")] Attack = 4,
			[Serialize("PlayerForcedAction_Win"   )] Win = 5,
		}
		public enum Enum_action {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0x425EC275;
	}
}

