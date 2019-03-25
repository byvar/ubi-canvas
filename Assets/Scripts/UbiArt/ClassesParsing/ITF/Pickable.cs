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

		protected virtual void InitGameObject() {
			gao = new GameObject(USERFRIENDLY);
			gao.transform.localPosition = new Vector3(POS2D.x, POS2D.y, -RELATIVEZ);
			gao.transform.localScale = new Vector3(SCALE.x, SCALE.y, 1f);
			gao.transform.localEulerAngles = new Vector3(0, 0, ANGLE.angle * Mathf.Rad2Deg);
			if (ANGLE.angle != 0f) gao.name += " - " + ANGLE.angle;
		}
		public void SetGameObjectParent(GameObject gp) {
			Gao.transform.SetParent(gp.transform);
			Gao.transform.localPosition = new Vector3(POS2D.x, POS2D.y, -RELATIVEZ);
			Gao.transform.localScale = new Vector3(SCALE.x, SCALE.y, 1f);
			Gao.transform.localEulerAngles = new Vector3(0, 0, ANGLE.angle * Mathf.Rad2Deg);
		}
	}
}
