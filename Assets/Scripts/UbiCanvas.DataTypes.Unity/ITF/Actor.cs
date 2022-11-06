using Cysharp.Threading.Tasks;
using UbiCanvas.Helpers;

namespace UbiArt.ITF {
	public partial class Actor {
		protected override async UniTask InitGameObject() {
			await base.InitGameObject();
			if (this is Frise) return;
			bool hasTemplate = (template != null && template.obj != null);
			bool hasTemplateComponents = hasTemplate && template.obj.COMPONENTS != null && template.obj.COMPONENTS.Count == COMPONENTS.Count;
			for (int i = 0; i < COMPONENTS.Count; i++) {
				Generic<ActorComponent> ac = COMPONENTS[i];
				if (ac != null && !ac.IsNull && ac.obj != null) {
					await TimeController.WaitIfNecessary();
					ac.obj.InitUnityComponent(this, gao, hasTemplateComponents ? template.obj.COMPONENTS[i].obj : null, i);
				}
			}
			if (hasTemplate) {
				for (int i = 0; i < template.obj.COMPONENTS.Count; i++) {
					Generic<ActorComponent_Template> ac = template.obj.COMPONENTS[i];
					if (ac != null && !ac.IsNull && ac.obj != null) {
						await TimeController.WaitIfNecessary();
						ac.obj.InitUnityComponent(this, template.obj, gao, i);
					}
				}
			}
		}
	}
}
