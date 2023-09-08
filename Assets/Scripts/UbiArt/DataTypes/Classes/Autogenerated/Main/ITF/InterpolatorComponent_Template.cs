namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class InterpolatorComponent_Template : ActorComponent_Template {
		public StringID input;
		public bool useMainCharacter;
		public bool canUseTouchScreenPlayers;
		public bool ignoreZ;
		public View view;

		public Enum_mode mode;
		public bool alwaysUseFirstPlayer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				input = s.SerializeObject<StringID>(input, name: "input");
				mode = s.Serialize<Enum_mode>(mode, name: "mode");
				useMainCharacter = s.Serialize<bool>(useMainCharacter, name: "useMainCharacter", options: CSerializerObject.Options.BoolAsByte);
				alwaysUseFirstPlayer = s.Serialize<bool>(alwaysUseFirstPlayer, name: "alwaysUseFirstPlayer", options: CSerializerObject.Options.BoolAsByte);
				canUseTouchScreenPlayers = s.Serialize<bool>(canUseTouchScreenPlayers, name: "canUseTouchScreenPlayers", options: CSerializerObject.Options.BoolAsByte);
				ignoreZ = s.Serialize<bool>(ignoreZ, name: "ignoreZ", options: CSerializerObject.Options.BoolAsByte);
				view = s.Serialize<View>(view, name: "view");
			} else {
				input = s.SerializeObject<StringID>(input, name: "input");
				useMainCharacter = s.Serialize<bool>(useMainCharacter, name: "useMainCharacter");
				canUseTouchScreenPlayers = s.Serialize<bool>(canUseTouchScreenPlayers, name: "canUseTouchScreenPlayers");
				ignoreZ = s.Serialize<bool>(ignoreZ, name: "ignoreZ");
				view = s.Serialize<View>(view, name: "view");
			}
		}
		public enum View {
			[Serialize("View::None"            )] None = 0,
			[Serialize("View::Main"            )] Main = 1,
			[Serialize("View::Remote"          )] Remote = 2,
			[Serialize("View::MainAndRemote"   )] MainAndRemote = 3,
			[Serialize("View::MainOnly"        )] MainOnly = 4,
			[Serialize("View::RemoteOnly"      )] RemoteOnly = 5,
			[Serialize("View::RemoteAsMainOnly")] RemoteAsMainOnly = 6,
			[Serialize("View::All"             )] All = -1,
		}
		public enum Enum_mode {
			[Serialize("Enum_mode::0")] Mode_0 = 0,
			[Serialize("Enum_mode::1")] Mode_1 = 1,
		}
		public override uint? ClassCRC => 0xD23A045B;
	}
}

