using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubSceneActor : Actor {
		[Serialize("RELATIVEPATH"   )] public Path RELATIVEPATH;
		[Serialize("EMBED_SCENE"    )] public bool EMBED_SCENE;
		[Serialize("IS_SINGLE_PIECE")] public bool IS_SINGLE_PIECE;
		[Serialize("ZFORCED"        )] public bool ZFORCED;
		[Serialize("DIRECT_PICKING" )] public bool DIRECT_PICKING;
		[Serialize("viewType"       )] public VIEWTYPE viewType;
		[Serialize("SCENE"          )] public Nullable<Scene> SCENE;
		[Serialize("xFLIPPED"       )] public bool xFLIPPED;
		[Serialize("parentBind"     )] public Placeholder parentBind;
		[Serialize("viewType"       )] public Enum_viewType viewType;
		[Serialize("USERFRIENDLY"   )] public string USERFRIENDLY;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					SerializeField(s, nameof(RELATIVEPATH));
					SerializeField(s, nameof(EMBED_SCENE));
					SerializeField(s, nameof(IS_SINGLE_PIECE));
					SerializeField(s, nameof(ZFORCED));
					SerializeField(s, nameof(xFLIPPED));
					SerializeField(s, nameof(parentBind));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(SCENE));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(RELATIVEPATH));
				SerializeField(s, nameof(EMBED_SCENE));
				SerializeField(s, nameof(IS_SINGLE_PIECE));
				SerializeField(s, nameof(ZFORCED));
				SerializeField(s, nameof(DIRECT_PICKING));
				SerializeField(s, nameof(viewType));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(SCENE));
				}
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					SerializeField(s, nameof(parentBind));
					SerializeField(s, nameof(USERFRIENDLY));
				}
			} else {
				SerializeField(s, nameof(RELATIVEPATH));
				SerializeField(s, nameof(EMBED_SCENE));
				SerializeField(s, nameof(IS_SINGLE_PIECE));
				SerializeField(s, nameof(ZFORCED));
				SerializeField(s, nameof(DIRECT_PICKING));
				SerializeField(s, nameof(viewType));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
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
		public enum Enum_viewType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public override uint? ClassCRC => 0x4FA40F09;
	}
}

