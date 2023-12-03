using System;
using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class Actor {
		public GenericFile<Actor_Template> template;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (this is Frise) return;
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;
				l.AddLoadedActor(this);
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

		protected Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.Game != settings.Game || previousSettings.Platform != settings.Platform) {
					//COMPONENTS = null;
					//LUA = new Path("enginedata/actortemplates/subscene.tpl");
					if (COMPONENTS != null && COMPONENTS.Count > 0) {
						List<Generic<ActorComponent>> RemovedComponents = new List<Generic<ActorComponent>>();
						// Check components, remove all that don't have the right gameflags
						for (int i = 0; i < COMPONENTS.Count; i++) {
							var compobj = COMPONENTS[i].obj;
							var newobj = compobj?.Convert(c, this, previousSettings, settings);
							if (newobj != compobj || compobj == null) {
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
									if (!attr.HasGame(settings.Game) || !attr.HasPlatform(settings.Platform)) {
										c.SystemLogger?.LogInfo("Removing actor component: {0}", compobj.GetType());
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
		public T GetComponent<T>() where T : ActorComponent {
			if (COMPONENTS == null) return null;
			return COMPONENTS.FirstOrDefault(c => (c?.obj as T) != null)?.obj as T;
		}
		public IEnumerable<T> GetComponents<T>() where T : ActorComponent {
			if (COMPONENTS == null) return null;
			return COMPONENTS.Where(c => (c?.obj as T) != null).Select(c => c?.obj as T);
		}

		public T AddComponent<T>(T t = null) where T : ActorComponent, new() {
			if (COMPONENTS == null) COMPONENTS = new CArrayO<Generic<ActorComponent>>();
			if (t == null) t = new T();
			COMPONENTS.Add(new Generic<ActorComponent>(t));
			return t;
		}
		public void RemoveComponent<T>(T t = null) where T : ActorComponent, new() {
			if (COMPONENTS == null) COMPONENTS = new CArrayO<Generic<ActorComponent>>();
			if (t == null) t = GetComponent<T>();
			if (t == null) return;
			var cmpObj = COMPONENTS.FirstOrDefault(c => c?.obj == t);
			COMPONENTS.Remove(cmpObj);
		}
	}
}
