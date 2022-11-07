namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class UIComponent : ActorComponent {
		public bool transition;
		public bool display;
		public StringID leftComponentID;
		public StringID rightComponentID;
		public StringID upComponentID;
		public StringID downComponentID;
		public bool buggyLine;
		public float showingFadeDuration;
		public float hidingFadeDuration;
		public View displayMask;
		public Vec2d screenSpace;
		public int UIState;
		public bool needsAspectRatioFix;
		public bool needsAspectRatioFixLocal;
		public float RELATIVEPOSX;
		public float RELATIVEPOSY;
		public string friendly;
		public StringID id;
		public string menuBaseName;
		public string menuSonBaseName;
		public string locFileName;
		public int defaultSelectedByInstance;
		public Align align;
		public string leftComponent;
		public string rightComponent;
		public string upComponent;
		public string downComponent;
		public Vec2d Vector2__6;
		public Vec2d Vector2__7;
		public float float__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.engineVersion == Settings.EngineVersion.RO) {
				if (this is UITextBox) return;
				if (s.HasFlags(SerializeFlags.Default)) {
					RELATIVEPOSX = s.Serialize<float>(RELATIVEPOSX, name: "RELATIVEPOSX");
					RELATIVEPOSY = s.Serialize<float>(RELATIVEPOSY, name: "RELATIVEPOSY");
					friendly = s.Serialize<string>(friendly, name: "friendly");
					id = s.SerializeObject<StringID>(id, name: "id");
					menuBaseName = s.Serialize<string>(menuBaseName, name: "menuBaseName");
					menuSonBaseName = s.Serialize<string>(menuSonBaseName, name: "menuSonBaseName");
					locFileName = s.Serialize<string>(locFileName, name: "locFileName");
					defaultSelectedByInstance = s.Serialize<int>(defaultSelectedByInstance, name: "defaultSelectedByInstance");
					align = s.Serialize<Align>(align, name: "align");
				}
			} else if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					transition = s.Serialize<bool>(transition, name: "transition");
					display = s.Serialize<bool>(display, name: "display");
					leftComponent = s.Serialize<string>(leftComponent, name: "leftComponent");
					rightComponent = s.Serialize<string>(rightComponent, name: "rightComponent");
					upComponent = s.Serialize<string>(upComponent, name: "upComponent");
					downComponent = s.Serialize<string>(downComponent, name: "downComponent");
					displayMask = s.Serialize<View>(displayMask, name: "displayMask");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					screenSpace = s.SerializeObject<Vec2d>(screenSpace, name: "screenSpace");
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					transition = s.Serialize<bool>(transition, name: "transition");
					display = s.Serialize<bool>(display, name: "display");
					displayMask = s.Serialize<View>(displayMask, name: "displayMask");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					screenSpace = s.SerializeObject<Vec2d>(screenSpace, name: "screenSpace");
				}
			} else if (s.Settings.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					transition = s.Serialize<bool>(transition, name: "transition");
					display = s.Serialize<bool>(display, name: "display");
					leftComponentID = s.SerializeObject<StringID>(leftComponentID, name: "leftComponentID");
					rightComponentID = s.SerializeObject<StringID>(rightComponentID, name: "rightComponentID");
					upComponentID = s.SerializeObject<StringID>(upComponentID, name: "upComponentID");
					downComponentID = s.SerializeObject<StringID>(downComponentID, name: "downComponentID");
					Vector2__6 = s.SerializeObject<Vec2d>(Vector2__6, name: "Vector2__6");
					Vector2__7 = s.SerializeObject<Vec2d>(Vector2__7, name: "Vector2__7");
					float__8 = s.Serialize<float>(float__8, name: "float__8");
					displayMask = s.Serialize<View>(displayMask, name: "displayMask");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					transition = s.Serialize<bool>(transition, name: "transition");
					display = s.Serialize<bool>(display, name: "display");
					if (s.HasFlags(SerializeFlags.Editor)) {
						leftComponentID = s.SerializeChoiceListObject<StringID>(leftComponentID, name: "leftComponentID", empty: "Empty");
						rightComponentID = s.SerializeChoiceListObject<StringID>(rightComponentID, name: "rightComponentID", empty: "Empty");
						upComponentID = s.SerializeChoiceListObject<StringID>(upComponentID, name: "upComponentID", empty: "Empty");
						downComponentID = s.SerializeChoiceListObject<StringID>(downComponentID, name: "downComponentID", empty: "Empty");
					} else {
						leftComponentID = s.SerializeObject<StringID>(leftComponentID, name: "leftComponentID");
						rightComponentID = s.SerializeObject<StringID>(rightComponentID, name: "rightComponentID");
						upComponentID = s.SerializeObject<StringID>(upComponentID, name: "upComponentID");
						downComponentID = s.SerializeObject<StringID>(downComponentID, name: "downComponentID");
					}
					buggyLine = s.Serialize<bool>(buggyLine, name: "buggyLine");
					showingFadeDuration = s.Serialize<float>(showingFadeDuration, name: "showingFadeDuration");
					hidingFadeDuration = s.Serialize<float>(hidingFadeDuration, name: "hidingFadeDuration");
					displayMask = s.Serialize<View>(displayMask, name: "displayMask");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					screenSpace = s.SerializeObject<Vec2d>(screenSpace, name: "screenSpace");
				}
				if (s.HasFlags(SerializeFlags.Editor)) {
					UIState = s.Serialize<int>(UIState, name: "UIState");
				}
				needsAspectRatioFix = s.Serialize<bool>(needsAspectRatioFix, name: "needsAspectRatioFix");
				needsAspectRatioFixLocal = s.Serialize<bool>(needsAspectRatioFixLocal, name: "needsAspectRatioFixLocal");
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
		public enum Align {
			[Serialize("align_free"    )] free = 0,
			[Serialize("align_centerX" )] centerX = 1,
			[Serialize("align_centerY" )] centerY = 2,
			[Serialize("align_centerXY")] centerXY = 3,
		}
		public override uint? ClassCRC => 0x850E4705;
	}
}

