using System.Collections.Generic;
using System.Linq;
using UbiArt.Animation;
using UbiCanvas;
using UbiCanvas.Helpers;
using UnityEngine;
using UnityEngine.Rendering;

namespace UbiArt.ITF {
	public partial class RO2_BezierTreeComponent {
		private RO2_BezierTreeComponent_Template tpl;

		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			if (template != null && template is RO2_BezierTreeComponent_Template) {
				tpl = template as RO2_BezierTreeComponent_Template;
				CreateGameObjects(gao, act);

			}
		}

		private void CreateGameObjects(GameObject gao, Actor act) {
			var context = UbiArtContext;

			var parentGao = new GameObject($"BezierTree");
			parentGao.transform.SetParent(gao.transform, false);
			parentGao.transform.localPosition = Vector3.zero;
			parentGao.transform.localRotation = Quaternion.identity;
			parentGao.transform.localScale = Vector3.one;

			var bezier = parentGao.AddComponent<UnityBezierRenderer>();
			bezier.Branch = branch;
			bezier.PickableForSelection = act;
		}
	}
}
