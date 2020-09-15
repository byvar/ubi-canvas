using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class EventPlayFX : Event {
		[Serialize("FXName"           )] public StringID FXName;
		[Serialize("Action"           )] public FX_St Action;
		[Serialize("BoneParent"       )] public StringID BoneParent;
		[Serialize("UseGlobalPosition")] public bool UseGlobalPosition;
		[Serialize("GlobalPosition"   )] public Vec3d GlobalPosition;
		[Serialize("StopImmediate"    )] public bool StopImmediate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(FXName));
				SerializeField(s, nameof(Action));
				SerializeField(s, nameof(BoneParent));
				SerializeField(s, nameof(UseGlobalPosition));
				SerializeField(s, nameof(GlobalPosition));
				SerializeField(s, nameof(StopImmediate));
			}
		}
		public enum FX_St {
			[Serialize("FX_Stop" )] op = 0,
			[Serialize("FX_Start")] art = 1,
		}
		public override uint? ClassCRC => 0x652C45A0;
	}
}

