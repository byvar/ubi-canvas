namespace UbiArt.ITF {
	public partial class AfterFxComponent_Template {
		public override ActorComponent_Template Convert(Actor_Template actor, Settings oldSettings, Settings newSettings) {
			base.Convert(actor, oldSettings, newSettings);
			if (oldSettings.game != newSettings.game) {
				if (newSettings.game == Settings.Game.RL) {
					finalblend2 = (GFX_BLEND2)(int)finalblend;
					afxtype2 = (AFX2)(int)afxtype;
				}
			}
			return this;
		}

		public AfterFxComponent_Template() {
			paramc = new CArrayO<Color>();
			paramf = new CArrayP<float>();
			paramv = new CListO<Vec3d>();
			parami = new CArrayP<int>();
			for (int i = 0; i < 8; i++) {
				paramf.Add(1f);
				parami.Add(0);
				paramv.Add(Vec3d.Zero);
			}
			for (int i = 0; i < 2; i++) {
				paramc.Add(new Color());
			}
		}
	}
}
