namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class Actor : Pickable {
		public Path LUA;
		public Nullable<Bind> parentBind;
		public CArrayO<Generic<ActorComponent>> COMPONENTS;
		public Nullable<ActorBind> parentBindOrigins;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				if (this is Frise) return;
				if (s.HasFlags(SerializeFlags.Default)) {
					LUA = s.SerializeObject<Path>(LUA, name: "LUA");
					xFLIPPED = s.Serialize<bool>(xFLIPPED, name: "xFLIPPED");
					parentBindOrigins = s.SerializeObject<Nullable<ActorBind>>(parentBindOrigins, name: "parentBind");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					COMPONENTS = s.SerializeObject<CArrayO<Generic<ActorComponent>>>(COMPONENTS, name: "COMPONENTS");
				}
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.VH) {
				if (this is Frise) return;
				if (s.Settings.platform == Settings.Platform.Vita) {
					uint lol = 0;
					lol = s.Serialize<uint>(lol, name: "placeholder");
					lol = s.Serialize<uint>(lol, name: "placeholder");
					lol = s.Serialize<uint>(lol, name: "placeholder");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					LUA = s.SerializeObject<Path>(LUA, name: "LUA");
					parentBind = s.SerializeObject<Nullable<Bind>>(parentBind, name: "parentBind");
				}
				if (s.HasFlags(SerializeFlags.Persistent | SerializeFlags.Default | SerializeFlags.Flags13 | SerializeFlags.Flags14)) {
					COMPONENTS = s.SerializeObject<CArrayO<Generic<ActorComponent>>>(COMPONENTS, name: "COMPONENTS");
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				if (this is Frise) return;
				if (s.HasFlags(SerializeFlags.Default)) {
					LUA = s.SerializeObject<Path>(LUA, name: "LUA");
					parentBind = s.SerializeObject<Nullable<Bind>>(parentBind, name: "parentBind");
				}
				if (s.HasFlags(SerializeFlags.Persistent | SerializeFlags.Default | SerializeFlags.Flags13 | SerializeFlags.Flags14
					| SerializeFlags.Flags16 | SerializeFlags.Flags17)) {
					COMPONENTS = s.SerializeObject<CArrayO<Generic<ActorComponent>>>(COMPONENTS, name: "COMPONENTS");
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
					COMPONENTS = s.SerializeObject<CArrayO<Generic<ActorComponent>>>(COMPONENTS, name: "COMPONENTS");
				}
			}
		}
		public override uint? ClassCRC => 0x97CA628B;
	}
}

