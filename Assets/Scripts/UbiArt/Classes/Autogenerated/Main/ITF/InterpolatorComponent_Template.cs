using UnityEngine;

namespace UbiArt.ITF {
	public partial class InterpolatorComponent_Template : ActorComponent_Template {
		[Serialize("input"                   )] public StringID input;
		[Serialize("useMainCharacter"        )] public bool useMainCharacter;
		[Serialize("canUseTouchScreenPlayers")] public bool canUseTouchScreenPlayers;
		[Serialize("ignoreZ"                 )] public bool ignoreZ;
		[Serialize("view"                    )] public View view;
		[Serialize("view"                    )] public Enum_view view;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(useMainCharacter));
				SerializeField(s, nameof(canUseTouchScreenPlayers));
				SerializeField(s, nameof(ignoreZ));
				SerializeField(s, nameof(view));
			} else {
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(useMainCharacter));
				SerializeField(s, nameof(canUseTouchScreenPlayers));
				SerializeField(s, nameof(ignoreZ));
				SerializeField(s, nameof(view));
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
		public enum Enum_view {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value__1")] Value__1 = -1,
		}
		public override uint? ClassCRC => 0xD23A045B;
	}
}

