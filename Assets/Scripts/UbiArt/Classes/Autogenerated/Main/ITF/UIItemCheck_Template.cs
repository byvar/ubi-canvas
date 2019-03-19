using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UIItemCheck_Template : UIItemBasic_Template {
		[Serialize("iconScalefactor")] public float iconScalefactor;
		[Serialize("tagUnchecked"   )] public SmartLocId tagUnchecked;
		[Serialize("tagChecked"     )] public SmartLocId tagChecked;
		[Serialize("tagText"        )] public CList<SmartLocId> tagText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(iconScalefactor));
			SerializeField(s, nameof(tagUnchecked));
			SerializeField(s, nameof(tagChecked));
			SerializeField(s, nameof(tagText));
		}
		public override uint? ClassCRC => 0x390DB316;
	}
}

