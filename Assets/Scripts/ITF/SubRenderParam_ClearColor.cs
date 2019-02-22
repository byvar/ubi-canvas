using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class SubRenderParam_ClearColor : BaseObject {
		[Serialize(0, "ClearColor")] public Color clearColor;
		[Serialize(1, "ClearFrontLightColor")] public Color clearFrontLightColor;
		[Serialize(2, "ClearBackLightColor")] public Color clearBackLightColor;

		public SubRenderParam_ClearColor(Reader reader) : base(reader) {
		}
	}
}
