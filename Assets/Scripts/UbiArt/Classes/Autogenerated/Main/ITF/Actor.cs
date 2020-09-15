using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class Actor : Pickable {
		public Path LUA;
		public Nullable<Bind> parentBind;
		public CArray<Generic<ActorComponent>> COMPONENTS;
		public Nullable<ActorBind> parentBindOrigins;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (this is Frise) return;
				if (s.HasFlags(SerializeFlags.Default)) {
					LUA = s.SerializeObject<Path>(LUA, name: "LUA");
					xFLIPPED = s.Serialize<bool>(xFLIPPED, name: "xFLIPPED");
					parentBindOrigins = s.SerializeObject<Nullable<ActorBind>>(parentBindOrigins, name: "parentBindOrigins");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					COMPONENTS = s.SerializeObject<CArray<Generic<ActorComponent>>>(COMPONENTS, name: "COMPONENTS");
				}
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				if (this is Frise) return;
				if (Settings.s.isCatchThemAll) {
					uint lol = 0;
					s.Serialize<uint>(ref lol, name: "placeholder");
					s.Serialize<uint>(ref lol, name: "placeholder");
					s.Serialize<uint>(ref lol, name: "placeholder");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					LUA = s.SerializeObject<Path>(LUA, name: "LUA");
					parentBind = s.SerializeObject<Nullable<Bind>>(parentBind, name: "parentBind");
				}
				if (s.HasFlags(SerializeFlags.Persistent | SerializeFlags.Default | SerializeFlags.Flags13 | SerializeFlags.Flags14)) {
					COMPONENTS = s.SerializeObject<CArray<Generic<ActorComponent>>>(COMPONENTS, name: "COMPONENTS");
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (this is Frise) return;
				if (s.HasFlags(SerializeFlags.Default)) {
					LUA = s.SerializeObject<Path>(LUA, name: "LUA");
					parentBind = s.SerializeObject<Nullable<Bind>>(parentBind, name: "parentBind");
				}
				if (s.HasFlags(SerializeFlags.Persistent | SerializeFlags.Default | SerializeFlags.Flags13 | SerializeFlags.Flags14
					| SerializeFlags.Flags16 | SerializeFlags.Flags17)) {
					COMPONENTS = s.SerializeObject<CArray<Generic<ActorComponent>>>(COMPONENTS, name: "COMPONENTS");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					LUA = s.SerializeObject<Path>(LUA, name: "LUA");
					parentBind = s.SerializeObject<Nullable<Bind>>(parentBind, name: "parentBind");
				}
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					parentBind = s.SerializeObject<Nullable<Bind>>(parentBind, name: "parentBind");
				}
				if (s.HasFlags(SerializeFlags.Persistent | SerializeFlags.Default | SerializeFlags.Flags13 | SerializeFlags.Flags14)) {
					COMPONENTS = s.SerializeObject<CArray<Generic<ActorComponent>>>(COMPONENTS, name: "COMPONENTS");
				}
			}
		}
		public override uint? ClassCRC => 0x97CA628B;
	}
}

