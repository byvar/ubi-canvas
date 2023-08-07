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

		protected virtual async UniTask InitGameObject() {
			gao = new GameObject(USERFRIENDLY);
			UbiArtContext.Loader.LoadingState = $"Creating objects\n{USERFRIENDLY}";
			await TimeController.WaitIfNecessary();
			gao.transform.localPosition = new Vector3(POS2D.x, POS2D.y, -RELATIVEZ);
			gao.transform.localScale = new Vector3((xFLIPPED ? -1f : 1f) * SCALE.x, SCALE.y, 1f);
			gao.transform.localEulerAngles = new Vector3(0, 0, ANGLE.EulerAngle);
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
			gao.transform.localPosition = new Vector3(POS2D.x, POS2D.y, -RELATIVEZ);
			gao.transform.localScale = new Vector3((xFLIPPED ? -1f : 1f) * SCALE.x, SCALE.y, 1f);
			gao.transform.localEulerAngles = new Vector3(0, 0, ANGLE.EulerAngle);
		}
		public async UniTask SetContainingScene(Scene sc) {
			if (gao == null) {
				await GetGameObject();
			}
			var pickable = gao.GetComponent<UnityPickable>();
			pickable.ContainingScene = sc;
		}
	}
}
