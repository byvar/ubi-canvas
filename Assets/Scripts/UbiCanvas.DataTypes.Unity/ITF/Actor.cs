using Cysharp.Threading.Tasks;
using System.Linq;
using UbiCanvas.Helpers;

namespace UbiArt.ITF {
	public partial class Actor {
		protected override async UniTask InitGameObject() {
			await base.InitGameObject();
			if (this is Frise) return;
			bool hasTemplate = template?.obj != null;
			bool hasTemplateComponents = hasTemplate && (template.obj.COMPONENTS?.Count ?? 0) == (COMPONENTS?.Count ?? 0);
			for (int i = 0; i < (COMPONENTS?.Count ?? 0); i++) {
				Generic<ActorComponent> ac = COMPONENTS[i];
				if (ac != null && !ac.IsNull && ac.obj != null) {
					await TimeController.WaitIfNecessary();
					if (hasTemplate && !hasTemplateComponents) {
						var matchingTPLComponent = template.obj.COMPONENTS.FirstOrDefault(c => c?.obj?.GetInstanceTypeName() == ac.obj.GetType().FullName);
						ac.obj.InitUnityComponent(this, gao, matchingTPLComponent?.obj, i);
					} else {
						ac.obj.InitUnityComponent(this, gao, hasTemplateComponents ? template.obj.COMPONENTS[i].obj : null, i);
					}
				}
			}
			if (hasTemplate) {
				for (int i = 0; i < (template.obj.COMPONENTS?.Count ?? 0); i++) {
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
