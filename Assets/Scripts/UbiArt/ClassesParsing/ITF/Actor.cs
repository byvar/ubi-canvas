using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class Actor {
		public GenericFile<Actor_Template> template;
		
		protected override async UniTask InitGameObject() {
			await base.InitGameObject();
			if (this is Frise) return;
			bool hasTemplate = (template != null && template.obj != null);
			bool hasTemplateComponents = hasTemplate && template.obj.COMPONENTS != null && template.obj.COMPONENTS.Count == COMPONENTS.Count;
			for (int i = 0; i < COMPONENTS.Count; i++) {
				Generic<ActorComponent> ac = COMPONENTS[i];
				if (ac != null && !ac.IsNull && ac.obj != null) {
					await Controller.WaitIfNecessary();
					ac.obj.InitUnityComponent(this, gao, hasTemplateComponents ? template.obj.COMPONENTS[i].obj : null, i);
				}
			}
			if (hasTemplate) {
				for (int i = 0; i < template.obj.COMPONENTS.Count; i++) {
					Generic<ActorComponent_Template> ac = template.obj.COMPONENTS[i];
					if (ac != null && !ac.IsNull && ac.obj != null) {
						await Controller.WaitIfNecessary();
						ac.obj.InitUnityComponent(this, template.obj, gao, i);
					}
				}
			}
		}

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (this is Frise) return;
			if (isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(LUA, (extS) => {
					if (l.tpl.ContainsKey(LUA.stringID)) {
						template = l.tpl[LUA.stringID];
					} else {
						extS.log = l.logEnabled;
						template = extS.SerializeObject<GenericFile<Actor_Template>>(template);
						l.tpl[LUA.stringID] = template;
					}
					if (template != null) {
						templatePickable = template.obj;
					}
				});
			}
		}
	}
}
