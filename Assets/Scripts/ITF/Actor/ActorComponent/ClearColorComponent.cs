using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class ClearColorComponent : ActorComponent {
		[Serialize(0, "clearColor", game = Settings.Game.RL)] public Color clearColor;
		[Serialize(1, "clearFrontLightColor", game = Settings.Game.RL)] public Color clearFrontLightColor;
		[Serialize(2, "clearBackLightColor", game = Settings.Game.RL)] public Color clearBackLightColor;
		
		[Serialize(0, "clearColor", game = Settings.Game.RA)] public SubRenderParam_ClearColor clearColorParam;
		[Serialize(1, "Weight", game = Settings.Game.RA)] public float weight;
		[Serialize(2, "Priority", game = Settings.Game.RA)] public uint priority;

		public ClearColorComponent(Reader reader) : base(reader) {
		}
	}
}
