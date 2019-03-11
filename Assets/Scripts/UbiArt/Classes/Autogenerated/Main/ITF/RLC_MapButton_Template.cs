using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_MapButton_Template : RLC_BasicAdventureButton_Template {
		[Serialize("WwiseGUID_SpawnLums"      )] public StringID WwiseGUID_SpawnLums;
		[Serialize("WwiseGUID_SpawnEnemy"     )] public StringID WwiseGUID_SpawnEnemy;
		[Serialize("WwiseGUID_SpawnExplo"     )] public StringID WwiseGUID_SpawnExplo;
		[Serialize("WwiseGUID_SpawnTimeAttack")] public StringID WwiseGUID_SpawnTimeAttack;
		[Serialize("WwiseGUID_SpawnHardLevel" )] public StringID WwiseGUID_SpawnHardLevel;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WwiseGUID_SpawnLums));
			SerializeField(s, nameof(WwiseGUID_SpawnEnemy));
			SerializeField(s, nameof(WwiseGUID_SpawnExplo));
			SerializeField(s, nameof(WwiseGUID_SpawnTimeAttack));
			SerializeField(s, nameof(WwiseGUID_SpawnHardLevel));
		}
		public override uint? ClassCRC => 0x079CB5D9;
	}
}

