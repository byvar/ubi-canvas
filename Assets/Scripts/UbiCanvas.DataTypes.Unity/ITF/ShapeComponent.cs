using System.Collections.Generic;
using System.Linq;
using UbiArt.Animation;
using UbiCanvas;
using UbiCanvas.Helpers;
using UnityEngine;
using UnityEngine.Rendering;

namespace UbiArt.ITF {
	public partial class ShapeComponent {
		private ShapeComponent_Template tpl;

		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			if (template != null && template is ShapeComponent_Template) {
				tpl = template as ShapeComponent_Template;
				CreateGameObjects(gao, act);

			}
		}

		private void CreateGameObjects(GameObject gao, Actor act) {
			var context = UbiArtContext;

			var parentGao = new GameObject($"Shape");
			parentGao.transform.SetParent(gao.transform, false);
			parentGao.transform.localPosition = Vector3.zero;
			parentGao.transform.localRotation = Quaternion.identity;
			parentGao.transform.localScale = Vector3.one;

			var box = parentGao.AddComponent<UnityShapeRenderer>();
			box.ShapeComponent = this;
			box.ShapeComponentTPL = tpl;
			box.PickableForSelection = act;
		}
	}
}
