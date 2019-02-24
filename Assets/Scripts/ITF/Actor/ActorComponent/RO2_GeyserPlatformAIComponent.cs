using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class RO2_GeyserPlatformAIComponent : GraphicComponent {
		[Serialize(0, "startOpen")] public bool startOpen;
		[Serialize(1, "platformHeight")] public float platformHeight;
		[Serialize(2, "angle")] public float angle;
		[Serialize(3, "width")] public float width;

		public RO2_GeyserPlatformAIComponent(Reader reader) : base(reader) {
		}
	}
}
