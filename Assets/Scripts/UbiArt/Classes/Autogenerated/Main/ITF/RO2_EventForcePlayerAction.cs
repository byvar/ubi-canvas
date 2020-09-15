using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class RO2_EventForcePlayerAction : Event {
		[Serialize("action"      )] public PlayerForcedAction action;
		[Serialize("action"      )] public PlayerForcedAction2 action2;
		[Serialize("enable"      )] public bool enable;
		[Serialize("direction"   )] public Vec2d direction;
		[Serialize("hold"        )] public bool hold;
		[Serialize("waitDuration")] public float waitDuration;
		[Serialize("sprint"      )] public bool sprint;
		[Serialize("priority"    )] public uint priority;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(action2));
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
		public enum PlayerForcedAction2 {
			[Serialize("PlayerForcedAction_None"  )] None = 0,
			[Serialize("PlayerForcedAction_Walk"  )] Walk = 1,
			[Serialize("PlayerForcedAction_Jump"  )] Jump = 2,
			[Serialize("PlayerForcedAction_Helico")] Helico = 3,
			[Serialize("PlayerForcedAction_Attack")] Attack = 4,
		}
		public override uint? ClassCRC => 0x425EC275;
	}
}

