using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SceneConfig_ChallengeTraining {
		public override void InitUnityComponent(Scene scene, GameObject gao, int index) {
			base.InitUnityComponent(scene, gao, index);
			if (mode != null && mode.obj != null && mode.obj is RO2_TrainingMode_Template) {
				RO2_TrainingMode_Template tpl = mode.obj as RO2_TrainingMode_Template;
				UnityGenericObject ugo = gao.AddComponent<UnityGenericObject>();
				ugo.obj = tpl;
			}
		}
	}
}
