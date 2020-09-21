using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class SceneConfigs : CSerializable {
		public uint activeSceneConfig;
		public CArrayO<Generic<SceneConfig>> sceneConfigs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activeSceneConfig = s.Serialize<uint>(activeSceneConfig, name: "activeSceneConfig");
			sceneConfigs = s.SerializeObject<CArrayO<Generic<SceneConfig>>>(sceneConfigs, name: "sceneConfigs");
		}
	}
}

