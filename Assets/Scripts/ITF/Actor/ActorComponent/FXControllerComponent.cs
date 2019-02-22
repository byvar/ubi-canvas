using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF.ActorComponents {
	public class FXControllerComponent : ActorComponent {
		[Serialize(0, "triggerFx")] public StringID triggerFx;
		[Serialize(1, "defaultFx")] public StringID defaultFx;
		[Serialize(2, "allowBusMixEvents", game = Settings.Game.RL)] public bool allowBusMixEvents;
		[Serialize(3, "allowMusicEvents", game = Settings.Game.RL)] public bool allowMusicEvents;
		public FXControllerComponent(Reader reader) : base(reader) {
		}
	}
}
