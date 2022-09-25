using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SceneConfig_ChallengeTraining {
		public GenericFile<CSerializable> mode;

		public override void InitUnityComponent(Scene scene, GameObject gao, int index) {
			base.InitUnityComponent(scene, gao, index);
			if (mode != null && mode.obj != null && mode.obj is RO2_TrainingMode_Template) {
				RO2_TrainingMode_Template tpl = mode.obj as RO2_TrainingMode_Template;
				UnityGenericObject ugo = gao.AddComponent<UnityGenericObject>();
				ugo.obj = tpl;
			}
		}

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				MapLoader l = s.Context;
				l.Load(modePath, (extS) => {
					if (l.isg.ContainsKey(modePath.stringID)) {
						mode = l.isg[modePath.stringID];
					} else {
						extS.log = l.logEnabled;
						mode = extS.SerializeObject<GenericFile<CSerializable>>(mode);
						l.isg[modePath.stringID] = mode;
					}
				});
			}
		}
	}
}
