using System;
using System.Collections.Generic;
using System.Linq;

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
							var newobj = compobj?.Convert(this, previousSettings, settings);
							if (newobj != compobj) {
								if (newobj == null) {
									RemovedComponents.Add(COMPONENTS[i]);
								} else {
									COMPONENTS[i].obj = newobj;
									COMPONENTS[i].className = new StringID(newobj.ClassCRC.Value);
								}
								compobj = newobj;
							}
							if (compobj != null) {
								var attr = (GamesAttribute)Attribute.GetCustomAttribute(compobj.GetType(), typeof(GamesAttribute));
								if (attr != null) {
									if (!attr.HasGame(settings.game)) {
										c.SystemLogger?.LogInfo("Removing actor_template component: {0}", compobj.GetType());
										RemovedComponents.Add(COMPONENTS[i]);
									}
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

		/// <summary>
		/// Gets first component of type T
		/// </summary>
		/// <typeparam name="T">Component type</typeparam>
		/// <returns>Component of the requested type</returns>
		public T GetComponent<T>() where T : ActorComponent_Template {
			if (COMPONENTS == null) return null;
			return COMPONENTS.FirstOrDefault(c => (c?.obj as T) != null)?.obj as T;
		}
	}
}
