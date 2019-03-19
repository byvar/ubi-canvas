using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LocalizationConfig_Template : CSerializable {
		[Serialize("locCharacterIDMap")] public Placeholder locCharacterIDMap;
		[Serialize("characterNames"   )] public Placeholder characterNames;
		[Serialize("skills"           )] public Placeholder skills;
		[Serialize("levelUpPopUp"     )] public Placeholder levelUpPopUp;
		[Serialize("inventory"        )] public Placeholder inventory;
		[Serialize("uplay"            )] public Placeholder uplay;
		[Serialize("trc"              )] public Placeholder trc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(locCharacterIDMap));
			SerializeField(s, nameof(characterNames));
			SerializeField(s, nameof(skills));
			SerializeField(s, nameof(levelUpPopUp));
			SerializeField(s, nameof(inventory));
			SerializeField(s, nameof(uplay));
			SerializeField(s, nameof(trc));
		}
		public override uint? ClassCRC => 0xF6DD4359;
	}
}

