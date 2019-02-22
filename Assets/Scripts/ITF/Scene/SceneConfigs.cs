using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class SceneConfigs : BaseObject {
		public uint activeSceneConfig;
		public Container<SceneConfig> sceneConfigs;

		public SceneConfigs(Reader reader) : base(reader) {
			activeSceneConfig = reader.ReadUInt32();
			sceneConfigs = new Container<SceneConfig>(reader, true);
		}
	}
}
