using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class EventPlayFX : Event {
		public StringID FXName;
		public FX_St Action;
		public StringID BoneParent;
		public bool UseGlobalPosition;
		public Vec3d GlobalPosition;
		public bool StopImmediate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.COL) {
			} else {
				FXName = s.SerializeObject<StringID>(FXName, name: "FXName");
				Action = s.Serialize<FX_St>(Action, name: "Action");
				BoneParent = s.SerializeObject<StringID>(BoneParent, name: "BoneParent");
				UseGlobalPosition = s.Serialize<bool>(UseGlobalPosition, name: "UseGlobalPosition");
				GlobalPosition = s.SerializeObject<Vec3d>(GlobalPosition, name: "GlobalPosition");
				StopImmediate = s.Serialize<bool>(StopImmediate, name: "StopImmediate");
			}
		}
		public enum FX_St {
			[Serialize("FX_Stop" )] op = 0,
			[Serialize("FX_Start")] art = 1,
		}
		public override uint? ClassCRC => 0x652C45A0;
	}
}

