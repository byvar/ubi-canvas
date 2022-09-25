using Cysharp.Threading.Tasks;
using UbiCanvas.Helpers;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class Pickable {
		protected GameObject gao;
		public async UniTask<GameObject> GetGameObject() {
			if (gao == null) {
				await InitGameObject();
			}
			return gao;
		}
		public TemplatePickable templatePickable;

		public Pickable() {
			ANGLE = new Angle(0);
			SCALE = Vec2d.One;
		}

		protected virtual async UniTask InitGameObject() {
			gao = new GameObject(USERFRIENDLY);
			UbiArtContext.loadingState = $"Creating objects\n{USERFRIENDLY}";
			await TimeController.WaitIfNecessary();
			gao.transform.localPosition = new Vec3d(POS2D.x, POS2D.y, -RELATIVEZ);
			gao.transform.localScale = new Vec3d((xFLIPPED ? -1f : 1f) * SCALE.x, SCALE.y, 1f);
			gao.transform.localEulerAngles = new Vec3d(0, 0, ANGLE.EulerAngle);
			UnityPickable p = gao.AddComponent<UnityPickable>();
			p.pickable = this;
			await UniTask.CompletedTask;
			//MapLoader.Loader.controller.zListManager.Register(this);
			//if (ANGLE.angle != 0f) gao.name += " - " + ANGLE.angle;
		}
		public async UniTask SetGameObjectParent(GameObject gp) {
			if (gao == null) {
				await GetGameObject();
			}
			gao.transform.SetParent(gp.transform, false);
			gao.transform.localPosition = new Vec3d(POS2D.x, POS2D.y, -RELATIVEZ);
			gao.transform.localScale = new Vec3d((xFLIPPED ? -1f : 1f) * SCALE.x, SCALE.y, 1f);
			gao.transform.localEulerAngles = new Vec3d(0, 0, ANGLE.EulerAngle);
		}
	}
}
