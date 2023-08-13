using System.Linq;
using System.Reflection;

namespace UbiArt.ITF {
	public partial class RopeComponent_Template {
		public override ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(context, actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if (newSettings.game == Settings.Game.RL) {
					return Merge<RO2_RopeComponent_Template>();
				}
			}
			return this;
		}
		public TTarget Merge<TTarget>() where TTarget : RO2_RopeComponent_Template, new() {
			var flags = BindingFlags.Instance | BindingFlags.Public |
						BindingFlags.NonPublic;
			var copyFrom = this;
			var targetDic = typeof(TTarget).GetFields(flags)
										   .ToDictionary(f => f.Name);
			var ret = new TTarget();
			foreach (var f in copyFrom.GetType().GetFields(flags)) {
				if (targetDic.ContainsKey(f.Name)) {
					if (f.FieldType == typeof(ConstraintSolverIterationPrecision)) {
						targetDic[f.Name].SetValue(ret, (RO2_RopeComponent_Template.ConstraintSolverIterationPrecision)(int)(ConstraintSolverIterationPrecision)f.GetValue(copyFrom));
					} else if (f.FieldType == typeof(CutFade)) {
						targetDic[f.Name].SetValue(ret, (RO2_RopeComponent_Template.CutFade)(int)(CutFade)f.GetValue(copyFrom));
					} else {
						targetDic[f.Name].SetValue(ret, f.GetValue(copyFrom));
					}
				}
			}
			return ret;
		}
	}
}
