using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCCharacterContent : CSerializable {
		[Serialize("characterstats"    )] public Path characterstats;
		[Serialize("characterskills"   )] public Path characterskills;
		[Serialize("characterassets"   )] public Path characterassets;
		[Serialize("characterfeedbacks")] public Path characterfeedbacks;
		[Serialize("charactermenus"    )] public Path charactermenus;
		[Serialize("characterui"       )] public Path characterui;
		[Serialize("characterskillsloc")] public Placeholder characterskillsloc;
		[Serialize("characteridmap"    )] public Placeholder characteridmap;
		[Serialize("characternames"    )] public Placeholder characternames;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(characterstats));
			SerializeField(s, nameof(characterskills));
			SerializeField(s, nameof(characterassets));
			SerializeField(s, nameof(characterfeedbacks));
			SerializeField(s, nameof(charactermenus));
			SerializeField(s, nameof(characterui));
			SerializeField(s, nameof(characterskillsloc));
			SerializeField(s, nameof(characteridmap));
			SerializeField(s, nameof(characternames));
		}
		public override uint? ClassCRC => 0x1ADB9275;
	}
}

