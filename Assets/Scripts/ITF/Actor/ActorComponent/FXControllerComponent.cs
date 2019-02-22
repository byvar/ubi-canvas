using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF.ActorComponents {
	public class FXControllerComponent : ActorComponent {
		public StringID triggerFx;
		public StringID defaultFx;
		public bool allowBusMixEvents;
		public bool allowMusicEvents;
		public FXControllerComponent(Reader reader) : base(reader) {
			triggerFx = new StringID(reader);
			defaultFx = new StringID(reader);
			allowBusMixEvents = reader.ReadBoolean();
			allowMusicEvents = reader.ReadBoolean();
		}
	}
}
