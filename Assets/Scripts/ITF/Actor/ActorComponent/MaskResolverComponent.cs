using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class MaskResolverComponent : ActorComponent {
		[Serialize(0, "clearFrontLightBuffer")]                         public bool clearFrontLightBuffer;
		[Serialize(1, "clearFrontLightColor")]                          public Color clearFrontLightColor;
		[Serialize(2, "clearBackLightBuffer")]                          public bool clearBackLightBuffer;
		[Serialize(3, "clearBackLightColor")]                           public Color clearBackLightColor;
		[Serialize(4, "blurFrontLightBuffer", game = Settings.Game.RL)] public bool blurFrontLightBuffer;
		[Serialize(5, "blurBackLightBuffer", game = Settings.Game.RL)]  public bool blurBackLightBuffer;
		[Serialize(6, "blurQuality", game = Settings.Game.RL)]          public uint blurQuality;
		[Serialize(7, "blurSize", game = Settings.Game.RL)]             public uint blurSize;
		[Serialize(7, "blurSize", game = Settings.Game.RA)]             public float blurSizeAdventures;

		public MaskResolverComponent(Reader reader) : base(reader) {
		}
	}
}
