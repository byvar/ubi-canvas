namespace UbiArt.ITF {
	public static class EventExtensions {
		public static bool IsAdventuresExclusive(this Event e) {
			if (e != null) {
				if (e.GetType().Name.Contains("RLC_")) return true;

				switch (e) {
					case EventLoadWwiseBank:
					case EventPlayWwiseEvent:
					case EventResetWwiseAuxBusEffect:
					case EventSetWwiseAuxBusEffect:
					case EventSetWwiseState:
					case EventSetWwiseSwitch:
					case EventUnloadWwiseBank:
						return true;
				}
			}
			return false;
		}
	}
}
