using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AudioEventManager_BattleData : CSerializable {
		[Serialize("startBattleNormal"       )] public Placeholder startBattleNormal;
		[Serialize("startBattlePreemptive"   )] public Placeholder startBattlePreemptive;
		[Serialize("startBattleAmbushed"     )] public Placeholder startBattleAmbushed;
		[Serialize("gameOverSfx"             )] public Placeholder gameOverSfx;
		[Serialize("musicStateBattleDefault" )] public StringID musicStateBattleDefault;
		[Serialize("musicStateBattleWin"     )] public StringID musicStateBattleWin;
		[Serialize("musicStateBattleLose"    )] public StringID musicStateBattleLose;
		[Serialize("musicStateBattleLevelUp" )] public StringID musicStateBattleLevelUp;
		[Serialize("musicStateBattleFlee"    )] public StringID musicStateBattleFlee;
		[Serialize("musicStateBattleMiniBoss")] public StringID musicStateBattleMiniBoss;
		[Serialize("musicStateBattleWinBoss" )] public StringID musicStateBattleWinBoss;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startBattleNormal));
			SerializeField(s, nameof(startBattlePreemptive));
			SerializeField(s, nameof(startBattleAmbushed));
			SerializeField(s, nameof(gameOverSfx));
			SerializeField(s, nameof(musicStateBattleDefault));
			SerializeField(s, nameof(musicStateBattleWin));
			SerializeField(s, nameof(musicStateBattleLose));
			SerializeField(s, nameof(musicStateBattleLevelUp));
			SerializeField(s, nameof(musicStateBattleFlee));
			SerializeField(s, nameof(musicStateBattleMiniBoss));
			SerializeField(s, nameof(musicStateBattleWinBoss));
		}
		public override uint? ClassCRC => 0xC62F093D;
	}
}

