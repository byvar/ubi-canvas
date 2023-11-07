using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class SceneConfigs {

		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.Game != settings.Game || previousSettings.Platform != settings.Platform) {
					if (sceneConfigs != null) {
						int subtractActiveSceneConfig = 0;
						List<Generic<SceneConfig>> RemovedComponents = new List<Generic<SceneConfig>>();
						// Check components, remove all that don't have the right gameflags
						for (int i = 0; i < sceneConfigs.Count; i++) {
							var compobj = sceneConfigs[i].obj;
							var newobj = compobj?.Convert(c, previousSettings, settings);
							if (newobj != compobj || compobj == null) {
								if (newobj == null) {
									RemovedComponents.Add(sceneConfigs[i]);
									if(activeSceneConfig >= i) subtractActiveSceneConfig++;
								} else {
									sceneConfigs[i].obj = newobj;
									sceneConfigs[i].className = new StringID(newobj.ClassCRC.Value);
								}
								compobj = newobj;
							}
							var attr = (GamesAttribute)Attribute.GetCustomAttribute(compobj.GetType(), typeof(GamesAttribute));
							if (attr != null) {
								if (!attr.HasGame(settings.Game) || !attr.HasPlatform(settings.Platform)) {
									c.SystemLogger?.LogInfo("Removing SceneConfig: {0}", compobj.GetType());
									RemovedComponents.Add(sceneConfigs[i]);
									if (activeSceneConfig >= i) subtractActiveSceneConfig++;
								}
							}
						}
						foreach (var comp in RemovedComponents) {
							sceneConfigs.Remove(comp);
						}
						if (subtractActiveSceneConfig > 0 && activeSceneConfig != uint.MaxValue) {
							activeSceneConfig = (uint)Math.Max(((int)activeSceneConfig) - subtractActiveSceneConfig, 0);
						}
					}
				}
			}
			previousSettings = settings;
		}
	}
}
