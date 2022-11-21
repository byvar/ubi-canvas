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
				if (previousSettings.game != settings.game) {
					if (sceneConfigs != null) {
						List<Generic<SceneConfig>> RemovedComponents = new List<Generic<SceneConfig>>();
						// Check components, remove all that don't have the right gameflags
						for (int i = 0; i < sceneConfigs.Count; i++) {
							var compobj = sceneConfigs[i].obj;
							var attr = (GamesAttribute)Attribute.GetCustomAttribute(compobj.GetType(), typeof(GamesAttribute));
							if (attr != null) {
								if (!attr.HasGame(settings.game)) {
									c.SystemLogger?.LogInfo("Removing SceneConfig: {0}", compobj.GetType());
									RemovedComponents.Add(sceneConfigs[i]);
								}
							}
						}
						foreach (var comp in RemovedComponents) {
							sceneConfigs.Remove(comp);
						}
					}
				}
			}
			previousSettings = settings;
		}
	}
}
