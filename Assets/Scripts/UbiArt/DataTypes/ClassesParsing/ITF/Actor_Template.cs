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
		public T AddComponent<T>(T t = null) where T : ActorComponent_Template, new() {
			if (COMPONENTS == null) COMPONENTS = new CArrayO<Generic<ActorComponent_Template>>();
			if (t == null) t = new T();
			COMPONENTS.Add(new Generic<ActorComponent_Template>(t));
			return t;
		}

		public Actor Instantiate(Path templatePath) {
			var basename = System.IO.Path.GetFileNameWithoutExtension(templatePath?.filename);
			var act = new Actor() {
				POS2D = Vec2d.Zero,
				USERFRIENDLY = basename,
				LUA = templatePath,
				template = new GenericFile<Actor_Template>(this),
				templatePickable = this,
			};
			act.InitContext(UbiArtContext);
			ActorComponent InstantiateComponent(ActorComponent_Template ctpl) {
				var tplType = ctpl.GetType();
				var typeName = tplType.FullName;
				if(typeName.Contains("_Template"))
					typeName = typeName.Replace("_Template","");

				Type type = Type.GetType(typeName);

				// Check whether the class exists
				if (type == null) throw new Exception($"Could not create instance class of component {tplType.FullName}");

				var c = (ActorComponent)Activator.CreateInstance(type);
				c.InitContext(UbiArtContext);
				return c;
			}
			act.COMPONENTS = new CArrayO<Generic<ActorComponent>>(COMPONENTS.Select(c => new Generic<ActorComponent>(InstantiateComponent(c.obj))).ToArray());
			return (Actor)act.Clone("act");
		}
	}
}
