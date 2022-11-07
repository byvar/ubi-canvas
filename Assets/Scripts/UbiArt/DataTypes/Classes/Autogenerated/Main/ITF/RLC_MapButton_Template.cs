namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_MapButton_Template : RLC_BasicAdventureButton_Template {
		public StringID WwiseGUID_SpawnLums;
		public StringID WwiseGUID_SpawnEnemy;
		public StringID WwiseGUID_SpawnExplo;
		public StringID WwiseGUID_SpawnTimeAttack;
		public StringID WwiseGUID_SpawnHardLevel;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			WwiseGUID_SpawnLums = s.SerializeObject<StringID>(WwiseGUID_SpawnLums, name: "WwiseGUID_SpawnLums");
			WwiseGUID_SpawnEnemy = s.SerializeObject<StringID>(WwiseGUID_SpawnEnemy, name: "WwiseGUID_SpawnEnemy");
			WwiseGUID_SpawnExplo = s.SerializeObject<StringID>(WwiseGUID_SpawnExplo, name: "WwiseGUID_SpawnExplo");
			WwiseGUID_SpawnTimeAttack = s.SerializeObject<StringID>(WwiseGUID_SpawnTimeAttack, name: "WwiseGUID_SpawnTimeAttack");
			WwiseGUID_SpawnHardLevel = s.SerializeObject<StringID>(WwiseGUID_SpawnHardLevel, name: "WwiseGUID_SpawnHardLevel");
		}
		public override uint? ClassCRC => 0x079CB5D9;
	}
}

