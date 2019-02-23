using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class UIComponent : ActorComponent {
		[Serialize(0, "transition")] public bool transition;
		[Serialize(1, "display")] public bool display;
		[Serialize(2, "leftComponent", game = Settings.Game.RL)] public string leftComponent;
		[Serialize(3, "rightComponent", game = Settings.Game.RL)] public string rightComponent;
		[Serialize(4, "upComponent", game = Settings.Game.RL)] public string upComponent;
		[Serialize(5, "downComponent", game = Settings.Game.RL)] public string downComponent;

		// these are the indices of the table accessible by ITF::StringID::getDebugString it seems. -1 for "Empty"
		[Serialize(2, "leftComponentID", game = Settings.Game.RA)] public int leftComponentID;
		[Serialize(3, "rightComponentID", game = Settings.Game.RA)] public int rightComponentID;
		[Serialize(4, "upComponentID", game = Settings.Game.RA)] public int upComponentID;
		[Serialize(5, "downComponentID", game = Settings.Game.RA)] public int downComponentID;

		[Serialize(6, "displayMask")] public View displayMask;
		[Serialize(7, "screenSpace")] public Vector2 screenSpace;
		[Serialize(8, "UIState", game = Settings.Game.RA)] public int UIState;
		[Serialize(9, "needsAspectRatioFix", game = Settings.Game.RA)] public bool needsAspectRatioFix;
		[Serialize(10, "needsAspectRatioFixLocal", game = Settings.Game.RA)] public bool needsAspectRatioFixLocal;

		public UIComponent(Reader reader) : base(reader) {
		}

		public enum View {
			All = -1,
			None,
			Main,
			Remote,
			MainAndRemote,
			MainOnly,
			RemoteOnly,
			MainAsRemoteOnly
		}
	}
}
