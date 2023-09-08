namespace UbiArt.ITF {
	public partial class RelayData {
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.Game != settings.Game) {
					if(eventToListen?.obj?.IsAdventuresExclusive() ?? false)
						eventToListen = null;
					if(eventToRelay?.obj?.IsAdventuresExclusive() ?? false)
						eventToRelay = null;
				}
			}
			previousSettings = settings;
		}
	}
}
