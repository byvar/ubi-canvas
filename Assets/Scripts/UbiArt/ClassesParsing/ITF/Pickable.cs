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

		public Pickable() {
			ANGLE = new Angle(0);
			SCALE = Vec2d.One;
		}

		protected virtual void InitGameObject() {
			gao = new GameObject(USERFRIENDLY);
			gao.transform.localPosition = new Vec3d(POS2D.x, POS2D.y, -RELATIVEZ);
			gao.transform.localScale = new Vec3d((xFLIPPED ? -1f : 1f) * SCALE.x, SCALE.y, 1f);
			gao.transform.localEulerAngles = new Vec3d(0, 0, ANGLE.EulerAngle);
			UnityPickable p = gao.AddComponent<UnityPickable>();
			p.pickable = this;
			//MapLoader.Loader.controller.zListManager.Register(this);
			//if (ANGLE.angle != 0f) gao.name += " - " + ANGLE.angle;
		}
		public void SetGameObjectParent(GameObject gp) {
			Gao.transform.SetParent(gp.transform, false);
			Gao.transform.localPosition = new Vec3d(POS2D.x, POS2D.y, -RELATIVEZ);
			Gao.transform.localScale = new Vec3d((xFLIPPED ? -1f : 1f) * SCALE.x, SCALE.y, 1f);
			Gao.transform.localEulerAngles = new Vec3d(0, 0, ANGLE.EulerAngle);
		}
	}
}
