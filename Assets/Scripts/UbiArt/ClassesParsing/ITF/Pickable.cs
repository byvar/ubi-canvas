using UnityEngine;

namespace UbiArt.ITF {
	public partial class Pickable {
		protected GameObject gao;
		public GameObject Gao {
			get {
				if (gao == null) {
					InitGameObject();
				}
				return gao;
			}
		}
		public TemplatePickable templatePickable;

		protected virtual void InitGameObject() {
			gao = new GameObject(USERFRIENDLY);
			gao.transform.localPosition = new Vector3(POS2D.x, POS2D.y, -RELATIVEZ);
			gao.transform.localScale = new Vector3((xFLIPPED ? -1f : 1f) * SCALE.x, SCALE.y, 1f);
			gao.transform.localEulerAngles = new Vector3(0, 0, ANGLE.EulerAngle);
			UnityPickable p = gao.AddComponent<UnityPickable>();
			p.pickable = this;
			//MapLoader.Loader.controller.zListManager.Register(this);
			//if (ANGLE.angle != 0f) gao.name += " - " + ANGLE.angle;
		}
		public void SetGameObjectParent(GameObject gp) {
			Gao.transform.SetParent(gp.transform, false);
			Gao.transform.localPosition = new Vector3(POS2D.x, POS2D.y, -RELATIVEZ);
			Gao.transform.localScale = new Vector3((xFLIPPED ? -1f : 1f) * SCALE.x, SCALE.y, 1f);
			Gao.transform.localEulerAngles = new Vector3(0, 0, ANGLE.EulerAngle);
		}
	}
}
