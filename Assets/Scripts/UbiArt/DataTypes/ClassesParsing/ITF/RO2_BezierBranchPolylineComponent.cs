namespace UbiArt.ITF {
	public partial class RO2_BezierBranchPolylineComponent {
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.Game != settings.Game) {
					if ((settings.Game == Game.RL || settings.Game == Game.VH)
						&& !(previousSettings.Game == Game.RL || previousSettings.Game == Game.VH)) {
						polylineMode2 = (RO2_PolylineMode2)(int)polylineMode;
						if(polylineMode == RO2_PolylineMode.LeftInverted)
							polylineMode2 = RO2_PolylineMode2.Left;
						else if(polylineMode == RO2_PolylineMode.RightInverted)
							polylineMode2 = RO2_PolylineMode2.Right;
					}
				}
			}
			previousSettings = settings;
		}
	}
}
