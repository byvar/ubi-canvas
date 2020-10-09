using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventForcePlayerAction : Event {
		public PlayerForcedAction action;
		public PlayerForcedAction2 action2;
		public bool enable;
		public Vec2d direction;
		public bool hold;
		public float waitDuration;
		public bool sprint;
		public uint priority;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				action2 = s.Serialize<PlayerForcedAction2>(action2, name: "action");
				enable = s.Serialize<bool>(enable, name: "enable");
				direction = s.SerializeObject<Vec2d>(direction, name: "direction");
				hold = s.Serialize<bool>(hold, name: "hold");
				waitDuration = s.Serialize<float>(waitDuration, name: "waitDuration");
				sprint = s.Serialize<bool>(sprint, name: "sprint");
				priority = s.Serialize<uint>(priority, name: "priority");
			} else {
				action = s.Serialize<PlayerForcedAction>(action, name: "action");
				enable = s.Serialize<bool>(enable, name: "enable");
				direction = s.SerializeObject<Vec2d>(direction, name: "direction");
				hold = s.Serialize<bool>(hold, name: "hold");
				waitDuration = s.Serialize<float>(waitDuration, name: "waitDuration");
				sprint = s.Serialize<bool>(sprint, name: "sprint");
				priority = s.Serialize<uint>(priority, name: "priority");
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

