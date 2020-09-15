using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class SceneConfig : CSerializable {
		public CArray<Generic<GameModeParameters>> gameModeParametersList;
		public StringID OnEnterFade;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				gameModeParametersList = s.SerializeObject<CArray<Generic<GameModeParameters>>>(gameModeParametersList, name: "gameModeParametersList");
			} else {
				gameModeParametersList = s.SerializeObject<CArray<Generic<GameModeParameters>>>(gameModeParametersList, name: "gameModeParametersList");
				OnEnterFade = s.SerializeObject<StringID>(OnEnterFade, name: "OnEnterFade");
			}
		}
		public override uint? ClassCRC => 0x8A44E40F;
	}
}

