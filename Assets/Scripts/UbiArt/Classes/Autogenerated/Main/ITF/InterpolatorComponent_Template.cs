using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class InterpolatorComponent_Template : ActorComponent_Template {
		[Serialize("input"                   )] public StringID input;
		[Serialize("useMainCharacter"        )] public bool useMainCharacter;
		[Serialize("canUseTouchScreenPlayers")] public bool canUseTouchScreenPlayers;
		[Serialize("ignoreZ"                 )] public bool ignoreZ;
		[Serialize("view"                    )] public View view;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(input));
			SerializeField(s, nameof(useMainCharacter));
			SerializeField(s, nameof(canUseTouchScreenPlayers));
			SerializeField(s, nameof(ignoreZ));
			SerializeField(s, nameof(view));
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
		public override uint? ClassCRC => 0xD23A045B;
	}
}

