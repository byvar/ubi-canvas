using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class AnimatedComponent : AnimLightComponent {
		[Serialize(0, "DebugAnimTransition", game = Settings.Game.RA)] public bool DebugAnimTransition;
		[Serialize(1, "EventPostComponents", game = Settings.Game.RA)] public Container<Event> eventPostComponents;

		public AnimatedComponent(Reader reader) : base(reader) {
		}
	}
}
