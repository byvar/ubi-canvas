using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class CharacterDebuggerComponent_Template : ActorComponent_Template {
		public bool showCollider;
		public bool showTrajectory;
		public bool debugController;
		public bool debugAnim;
		public bool debugAnimInputs;
		public bool debugAI;
		public uint debugMaxTrajectory;
		public bool debugSoundInputs;
		public bool debugActorPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				showCollider = s.Serialize<bool>(showCollider, name: "showCollider");
				showTrajectory = s.Serialize<bool>(showTrajectory, name: "showTrajectory");
				debugController = s.Serialize<bool>(debugController, name: "debugController");
				debugAnim = s.Serialize<bool>(debugAnim, name: "debugAnim");
				debugAnimInputs = s.Serialize<bool>(debugAnimInputs, name: "debugAnimInputs");
				debugAI = s.Serialize<bool>(debugAI, name: "debugAI");
				debugMaxTrajectory = s.Serialize<uint>(debugMaxTrajectory, name: "debugMaxTrajectory");
				debugSoundInputs = s.Serialize<bool>(debugSoundInputs, name: "debugSoundInputs");
			} else {
				showCollider = s.Serialize<bool>(showCollider, name: "showCollider");
				showTrajectory = s.Serialize<bool>(showTrajectory, name: "showTrajectory");
				debugController = s.Serialize<bool>(debugController, name: "debugController");
				debugAnim = s.Serialize<bool>(debugAnim, name: "debugAnim");
				debugAnimInputs = s.Serialize<bool>(debugAnimInputs, name: "debugAnimInputs");
				debugAI = s.Serialize<bool>(debugAI, name: "debugAI");
				debugMaxTrajectory = s.Serialize<uint>(debugMaxTrajectory, name: "debugMaxTrajectory");
				debugSoundInputs = s.Serialize<bool>(debugSoundInputs, name: "debugSoundInputs");
				debugActorPos = s.Serialize<bool>(debugActorPos, name: "debugActorPos");
			}
		}
		public override uint? ClassCRC => 0x832235B6;
	}
}

