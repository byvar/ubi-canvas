using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class GraphicComponent : ActorComponent {
		public GFXPrimitiveParam primitiveParameters;
		public uint colorComputerTagId;
		public bool renderInTarget;
		public bool disableLight;
		public int disableShadow; // actually a bool, but it seems to be stored as 0xFFFFFFFF sometimes, and we need to save that later
		public float depthOffset;

		public GraphicComponent(Reader reader) : base(reader) {
			primitiveParameters = new GFXPrimitiveParam(reader);
			//Debug.LogError("Decipher GraphiComponent @ " + Pointer.Current(reader));
			//MapLoader.Loader.print("GFXC @ " + Pointer.Current(reader));
			colorComputerTagId = reader.ReadUInt32();
			renderInTarget = reader.ReadBoolean();
			disableLight = reader.ReadBoolean();
			disableShadow = reader.ReadInt32();
			depthOffset = reader.ReadSingle();
		}
	}
}
