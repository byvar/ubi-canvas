using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class SceneConfigs : CSerializable {
		[Serialize("activeSceneConfig")] public uint activeSceneConfig;
		[Serialize("sceneConfigs"     )] public CArray<Generic<SceneConfig>> sceneConfigs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activeSceneConfig));
			SerializeField(s, nameof(sceneConfigs));
		}
	}
}

