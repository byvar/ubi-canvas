using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class Actor_Template {

		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					if (COMPONENTS != null) {
						List<Generic<ActorComponent_Template>> RemovedComponents = new List<Generic<ActorComponent_Template>>();
						// Check components, remove all that don't have the right gameflags
						for (int i = 0; i < COMPONENTS.Count; i++) {
							var compobj = COMPONENTS[i].obj;
							var attr = (GamesAttribute)Attribute.GetCustomAttribute(compobj.GetType(), typeof(GamesAttribute));
							if (attr != null) {
								if (!attr.HasGame(settings.game)) {
									c.SystemLogger?.LogInfo("Removing actor_template component: {0}", compobj.GetType());
									RemovedComponents.Add(COMPONENTS[i]);
								}
							}
						}
						foreach (var comp in RemovedComponents) {
							COMPONENTS.Remove(comp);
						}
					}
				}
			}
			previousSettings = settings;
		}
	}
}
