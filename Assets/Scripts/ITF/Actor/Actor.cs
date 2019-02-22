using ITF.ActorComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Actor : Pickable {
		[Serialize(0, "LUA")]        public Path lua; // [Description(\"this is the lua file used for the template\")]
		[Serialize(1, "parentBind")] public Nullable<Bind> parentBind;
		[Serialize(2, "COMPONENTS")] public Container<Generic<ActorComponent>> components;

		protected override void InitGameObject() {
			base.InitGameObject();
			foreach (Generic<ActorComponent> ac in components) {
				UnityActorComponentPlaceholder p = gao.AddComponent<UnityActorComponentPlaceholder>();
				p.name = ac.obj.GetType().Name;
			}
		}

		public Actor(Reader reader) : base(reader) {
		}
	}
}
