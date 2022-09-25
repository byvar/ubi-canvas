using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_HoverPlatformComponent_Template : ActorComponent_Template {
		public float movePhase;
		public float waitPhase;
		public bool fxReactor01Enabled;
		public bool fxReactor02Enabled;
		public bool fxReactor03Enabled;
		public bool landEnabled;
		public bool chainEnabled;
		public Path chainPath;
		public int animDeathEnabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				movePhase = s.Serialize<float>(movePhase, name: "movePhase");
				waitPhase = s.Serialize<float>(waitPhase, name: "waitPhase");
				fxReactor01Enabled = s.Serialize<bool>(fxReactor01Enabled, name: "fxReactor01Enabled");
				fxReactor02Enabled = s.Serialize<bool>(fxReactor02Enabled, name: "fxReactor02Enabled");
				fxReactor03Enabled = s.Serialize<bool>(fxReactor03Enabled, name: "fxReactor03Enabled");
				landEnabled = s.Serialize<bool>(landEnabled, name: "landEnabled");
				chainEnabled = s.Serialize<bool>(chainEnabled, name: "chainEnabled");
				chainPath = s.SerializeObject<Path>(chainPath, name: "chainPath");
				animDeathEnabled = s.Serialize<int>(animDeathEnabled, name: "animDeathEnabled");
			} else {
				movePhase = s.Serialize<float>(movePhase, name: "movePhase");
				waitPhase = s.Serialize<float>(waitPhase, name: "waitPhase");
				fxReactor01Enabled = s.Serialize<bool>(fxReactor01Enabled, name: "fxReactor01Enabled");
				fxReactor02Enabled = s.Serialize<bool>(fxReactor02Enabled, name: "fxReactor02Enabled");
				fxReactor03Enabled = s.Serialize<bool>(fxReactor03Enabled, name: "fxReactor03Enabled");
				landEnabled = s.Serialize<bool>(landEnabled, name: "landEnabled");
				chainEnabled = s.Serialize<bool>(chainEnabled, name: "chainEnabled");
				chainPath = s.SerializeObject<Path>(chainPath, name: "chainPath");
			}
		}
		public override uint? ClassCRC => 0x5A8B0C8F;
	}
}

