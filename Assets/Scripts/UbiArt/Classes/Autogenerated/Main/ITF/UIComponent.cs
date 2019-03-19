using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UIComponent : ActorComponent {
		[Serialize("transition"               )] public bool transition;
		[Serialize("display"                  )] public bool display;
		[Serialize("leftComponentID"          )] public Enum_leftComponentID leftComponentID;
		[Serialize("rightComponentID"         )] public Enum_rightComponentID rightComponentID;
		[Serialize("upComponentID"            )] public Enum_upComponentID upComponentID;
		[Serialize("downComponentID"          )] public Enum_downComponentID downComponentID;
		[Serialize("buggyLine"                )] public bool buggyLine;
		[Serialize("showingFadeDuration"      )] public float showingFadeDuration;
		[Serialize("hidingFadeDuration"       )] public float hidingFadeDuration;
		[Serialize("displayMask"              )] public View displayMask;
		[Serialize("screenSpace"              )] public Vector2 screenSpace;
		[Serialize("UIState"                  )] public int UIState;
		[Serialize("needsAspectRatioFix"      )] public bool needsAspectRatioFix;
		[Serialize("needsAspectRatioFixLocal" )] public bool needsAspectRatioFixLocal;
		[Serialize("RELATIVEPOSX"             )] public float RELATIVEPOSX;
		[Serialize("RELATIVEPOSY"             )] public float RELATIVEPOSY;
		[Serialize("friendly"                 )] public string friendly;
		[Serialize("id"                       )] public StringID id;
		[Serialize("menuBaseName"             )] public string menuBaseName;
		[Serialize("menuSonBaseName"          )] public string menuSonBaseName;
		[Serialize("locFileName"              )] public string locFileName;
		[Serialize("defaultSelectedByInstance")] public int defaultSelectedByInstance;
		[Serialize("align"                    )] public Align align;
		[Serialize("leftComponent"            )] public string leftComponent;
		[Serialize("rightComponent"           )] public string rightComponent;
		[Serialize("upComponent"              )] public string upComponent;
		[Serialize("downComponent"            )] public string downComponent;
		[Serialize("StringID__2"              )] public StringID StringID__2;
		[Serialize("StringID__3"              )] public StringID StringID__3;
		[Serialize("StringID__4"              )] public StringID StringID__4;
		[Serialize("StringID__5"              )] public StringID StringID__5;
		[Serialize("Vector2__6"               )] public Vector2 Vector2__6;
		[Serialize("Vector2__7"               )] public Vector2 Vector2__7;
		[Serialize("float__8"                 )] public float float__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(RELATIVEPOSX));
					SerializeField(s, nameof(RELATIVEPOSY));
					SerializeField(s, nameof(friendly));
					SerializeField(s, nameof(id));
					SerializeField(s, nameof(menuBaseName));
					SerializeField(s, nameof(menuSonBaseName));
					SerializeField(s, nameof(locFileName));
					SerializeField(s, nameof(defaultSelectedByInstance));
					SerializeField(s, nameof(align));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(transition));
					SerializeField(s, nameof(display));
					SerializeField(s, nameof(leftComponent));
					SerializeField(s, nameof(rightComponent));
					SerializeField(s, nameof(upComponent));
					SerializeField(s, nameof(downComponent));
					SerializeField(s, nameof(displayMask));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(screenSpace));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(transition));
					SerializeField(s, nameof(display));
					SerializeField(s, nameof(displayMask));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(screenSpace));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(transition));
					SerializeField(s, nameof(display));
					SerializeField(s, nameof(StringID__2));
					SerializeField(s, nameof(StringID__3));
					SerializeField(s, nameof(StringID__4));
					SerializeField(s, nameof(StringID__5));
					SerializeField(s, nameof(Vector2__6));
					SerializeField(s, nameof(Vector2__7));
					SerializeField(s, nameof(float__8));
					SerializeField(s, nameof(displayMask));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(transition));
					SerializeField(s, nameof(display));
					SerializeField(s, nameof(leftComponentID));
					SerializeField(s, nameof(rightComponentID));
					SerializeField(s, nameof(upComponentID));
					SerializeField(s, nameof(downComponentID));
					SerializeField(s, nameof(buggyLine));
					SerializeField(s, nameof(showingFadeDuration));
					SerializeField(s, nameof(hidingFadeDuration));
					SerializeField(s, nameof(displayMask));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(screenSpace));
				}
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(UIState));
				}
				SerializeField(s, nameof(needsAspectRatioFix));
				SerializeField(s, nameof(needsAspectRatioFixLocal));
			}
		}
		public enum Enum_leftComponentID {
			[Serialize("Empty")] Empty = -1,
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
		public enum Align {
			[Serialize("align_free"    )] free = 0,
			[Serialize("align_centerX" )] centerX = 1,
			[Serialize("align_centerY" )] centerY = 2,
			[Serialize("align_centerXY")] centerXY = 3,
		}
		public override uint? ClassCRC => 0x850E4705;
	}
}

