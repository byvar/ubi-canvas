using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class Actor : Pickable {
		[Serialize("LUA"       )] public Path LUA;
		[Serialize("parentBind")] public Nullable<Bind> parentBind;
		[Serialize("COMPONENTS")] public CArray<Generic<ActorComponent>> COMPONENTS;
		[Serialize("parentBind")] public Nullable<ActorBind> parentBindOrigins;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (this is Frise) return;
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(LUA));
					SerializeField(s, nameof(xFLIPPED));
					SerializeField(s, nameof(parentBindOrigins));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(COMPONENTS));
				}
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				if (this is Frise) return;
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(LUA));
					SerializeField(s, nameof(parentBind));
				}
				if (s.HasFlags(SerializeFlags.Persistent | SerializeFlags.Default | SerializeFlags.Flags13 | SerializeFlags.Flags14)) {
					SerializeField(s, nameof(COMPONENTS));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (this is Frise) return;
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(LUA));
					SerializeField(s, nameof(parentBind));
				}
				if (s.HasFlags(SerializeFlags.Persistent | SerializeFlags.Default | SerializeFlags.Flags13 | SerializeFlags.Flags14
					| SerializeFlags.Flags16 | SerializeFlags.Flags17)) {
					SerializeField(s, nameof(COMPONENTS));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(LUA));
					SerializeField(s, nameof(parentBind));
				}
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					SerializeField(s, nameof(parentBind));
				}
				if (s.HasFlags(SerializeFlags.Persistent | SerializeFlags.Default | SerializeFlags.Flags13 | SerializeFlags.Flags14)) {
					SerializeField(s, nameof(COMPONENTS));
				}
			}
		}
		public override uint? ClassCRC => 0x97CA628B;
	}
}

