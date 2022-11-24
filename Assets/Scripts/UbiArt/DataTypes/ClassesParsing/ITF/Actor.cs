using System;
using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class Actor {
		public GenericFile<Actor_Template> template;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (this is Frise) return;
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;
				l.LoadFile<GenericFile<Actor_Template>>(LUA, result => {
					template = result;
					if (template != null)
						templatePickable = template.obj;
				});
			}
		}

		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					//COMPONENTS = null;
					//LUA = new Path("enginedata/actortemplates/subscene.tpl");
					if (COMPONENTS != null) {
						List<Generic<ActorComponent>> RemovedComponents = new List<Generic<ActorComponent>>();
						// Check components, remove all that don't have the right gameflags
						for (int i = 0; i < COMPONENTS.Count; i++) {
							var compobj = COMPONENTS[i].obj;
							var attr = (GamesAttribute)Attribute.GetCustomAttribute(compobj.GetType(), typeof(GamesAttribute));
							if (attr != null) {
								if (!attr.HasGame(settings.game)) {
									c.SystemLogger?.LogInfo("Removing actor component: {0}",compobj.GetType());
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
