using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class TouchScreenInputComponent : ShapeComponent {
		[Serialize(0, "viewName", game = Settings.Game.RA)] public string viewName;
		public TouchScreenInputComponent(Reader reader) : base(reader) {
		}
	}
}
