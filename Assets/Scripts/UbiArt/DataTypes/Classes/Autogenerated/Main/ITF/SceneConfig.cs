using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class SceneConfig : CSerializable {
		public CArrayO<Generic<GameModeParameters>> gameModeParametersList;
		public StringID OnEnterFade;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.VH) {
				gameModeParametersList = s.SerializeObject<CArrayO<Generic<GameModeParameters>>>(gameModeParametersList, name: "gameModeParametersList");
			} else {
				gameModeParametersList = s.SerializeObject<CArrayO<Generic<GameModeParameters>>>(gameModeParametersList, name: "gameModeParametersList");
				OnEnterFade = s.SerializeObject<StringID>(OnEnterFade, name: "OnEnterFade");
			}
		}
		public override uint? ClassCRC => 0x8A44E40F;
	}
}

