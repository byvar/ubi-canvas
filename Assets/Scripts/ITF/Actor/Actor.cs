using ITF.ActorComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Actor : Pickable {
		public Path lua; // [Description(\"this is the lua file used for the template\")]
		public Bind parentBind;
		public Container<ActorComponent> components;

		protected override void InitGameObject() {
			base.InitGameObject();
			foreach (ActorComponent ac in components) {
				UnityActorComponentPlaceholder p = gao.AddComponent<UnityActorComponentPlaceholder>();
				p.name = ac.GetType().Name;
			}
		}

		public Actor(Reader reader) : base(reader) {
			lua = new Path(reader);
			parentBind = new Bind(reader);
			components = new Container<ActorComponent>(reader, true);
		}
	}
}
