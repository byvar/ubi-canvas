using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class GraphicComponent : ActorComponent {
		[Serialize(0, "PrimitiveParameters")] public GFXPrimitiveParam primitiveParameters;
		[Serialize(1, "colorComputerTagId")] public uint colorComputerTagId;
		[Serialize(2, "renderInTarget")] public bool renderInTarget;
		[Serialize(3, "disableLight")] public int disableLight;
		[Serialize(4, "disableShadow")] public int disableShadow; // actually a bool, but it seems to be stored as 0xFFFFFFFF sometimes, and we need to save that later
		[Serialize(5, "depthOffset")] public float depthOffset;

		public GraphicComponent(Reader reader) : base(reader) {
		}
	}
}
