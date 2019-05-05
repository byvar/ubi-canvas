using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class SubSceneActor : Actor {
		[Serialize("RELATIVEPATH"   )] public Path RELATIVEPATH;
		[Serialize("EMBED_SCENE"    )] public bool EMBED_SCENE;
		[Serialize("IS_SINGLE_PIECE")] public bool IS_SINGLE_PIECE;
		[Serialize("ZFORCED"        )] public bool ZFORCED;
		[Serialize("DIRECT_PICKING" )] public bool DIRECT_PICKING;
		[Serialize("viewType"       )] public VIEWTYPE viewType;
		[Serialize("SCENE"          )] public Nullable<Scene> SCENE;
		[Serialize("SCENE"          )] public Generic<Scene> SCENE_ORIGINS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					SerializeField(s, nameof(RELATIVEPATH));
					SerializeField(s, nameof(EMBED_SCENE));
					SerializeField(s, nameof(IS_SINGLE_PIECE));
					SerializeField(s, nameof(ZFORCED));
					SerializeField(s, nameof(xFLIPPED));
					SerializeField(s, nameof(parentBindOrigins)); // Serialized a second time
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(RELATIVEPATH));
					SerializeField(s, nameof(EMBED_SCENE));
					SerializeField(s, nameof(IS_SINGLE_PIECE));
					SerializeField(s, nameof(ZFORCED));
					if (EMBED_SCENE) {
						SerializeField(s, nameof(SCENE_ORIGINS));
					}
				}
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(RELATIVEPATH));
				SerializeField(s, nameof(EMBED_SCENE));
				SerializeField(s, nameof(IS_SINGLE_PIECE));
				SerializeField(s, nameof(ZFORCED));
				SerializeField(s, nameof(DIRECT_PICKING));
				SerializeField(s, nameof(viewType));
				if (s.HasFlags(SerializeFlags.Flags_xC0) && EMBED_SCENE) {
					SerializeField(s, nameof(SCENE));
				}
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					if (s.HasFlags(SerializeFlags.Flags11 | SerializeFlags.Flags12)) {
						SerializeField(s, nameof(parentBind)); // Serialized a second time
					}
					if (!s.HasFlags(SerializeFlags.Default)) {
						SerializeField(s, nameof(USERFRIENDLY)); // Serialized a second time
					}
				}
			} else {
				SerializeField(s, nameof(RELATIVEPATH));
				SerializeField(s, nameof(EMBED_SCENE));
				SerializeField(s, nameof(IS_SINGLE_PIECE));
				SerializeField(s, nameof(ZFORCED));
				SerializeField(s, nameof(DIRECT_PICKING));
				SerializeField(s, nameof(viewType));
				if (s.HasFlags(SerializeFlags.Flags_xC0) && EMBED_SCENE) {
					SerializeField(s, nameof(SCENE));
				}
				if (s.HasFlags(SerializeFlags.Flags15)) {
					SerializeField(s, nameof(SCENE));
				}
			}
		}
		public enum VIEWTYPE {
			[Serialize("VIEWTYPE_MAIN"             )] MAIN = 0,
			[Serialize("VIEWTYPE_REMOTE"           )] REMOTE = 1,
			[Serialize("VIEWTYPE_ALL"              )] ALL = 2,
			[Serialize("VIEWTYPE_MAINONLY"         )] MAINONLY = 3,
			[Serialize("VIEWTYPE_REMOTEONLY"       )] REMOTEONLY = 4,
			[Serialize("VIEWTYPE_REMOTEASMAIN_ONLY")] REMOTEASMAIN_ONLY = 5,
		}
		public override uint? ClassCRC => 0x4FA40F09;
	}
}

