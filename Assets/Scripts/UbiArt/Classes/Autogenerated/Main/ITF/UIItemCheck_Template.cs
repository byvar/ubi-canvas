using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UIItemCheck_Template : UIItemBasic_Template {
		public float iconScalefactor;
		public SmartLocId tagUnchecked;
		public SmartLocId tagChecked;
		public CList<SmartLocId> tagText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			iconScalefactor = s.Serialize<float>(iconScalefactor, name: "iconScalefactor");
			tagUnchecked = s.SerializeObject<SmartLocId>(tagUnchecked, name: "tagUnchecked");
			tagChecked = s.SerializeObject<SmartLocId>(tagChecked, name: "tagChecked");
			tagText = s.SerializeObject<CList<SmartLocId>>(tagText, name: "tagText");
		}
		public override uint? ClassCRC => 0x390DB316;
	}
}

