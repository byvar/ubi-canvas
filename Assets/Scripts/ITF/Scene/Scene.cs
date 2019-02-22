using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Scene : BaseObject {
		[Serialize(0, "ENGINE_VERSION")] public uint engineVersion;
		[Serialize(1, "DEPENDENCIES")] public Container<Path> dependencies;
		[Serialize(2, "FRISE")] public Container<Frise> frise;
		[Serialize(3, "METAFRIEZE")] public Container<MetaFrieze> metafrieze;
		[Serialize(4, "ACTORS")] public Container<Generic<Actor>> actors;
		[Serialize(5, "friezeConnections")] public Container<FriezeConnectionResult> friezeConnections;
		[Serialize(6, "sceneConfigs")] public SceneConfigs sceneConfigs;

		public Scene(Reader reader) : base(reader) {
		}
	}
}
