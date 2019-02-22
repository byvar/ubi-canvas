using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class SceneConfigs : BaseObject {
		[Serialize(0, "activeSceneConfig")] public uint activeSceneConfig;
		[Serialize(1, "sceneConfigs")] public Container<Generic<SceneConfig>> sceneConfigs;

		public SceneConfigs(Reader reader) : base(reader) {
		}
	}
}
