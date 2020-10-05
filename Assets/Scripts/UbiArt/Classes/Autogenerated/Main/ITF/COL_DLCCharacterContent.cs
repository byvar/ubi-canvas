using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCCharacterContent : CSerializable {
		public Path characterstats;
		public Path characterskills;
		public Path characterassets;
		public Path characterfeedbacks;
		public Path charactermenus;
		public Path characterui;
		public Placeholder characterskillsloc;
		public Placeholder characteridmap;
		public Placeholder characternames;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			characterstats = s.SerializeObject<Path>(characterstats, name: "characterstats");
			characterskills = s.SerializeObject<Path>(characterskills, name: "characterskills");
			characterassets = s.SerializeObject<Path>(characterassets, name: "characterassets");
			characterfeedbacks = s.SerializeObject<Path>(characterfeedbacks, name: "characterfeedbacks");
			charactermenus = s.SerializeObject<Path>(charactermenus, name: "charactermenus");
			characterui = s.SerializeObject<Path>(characterui, name: "characterui");
			characterskillsloc = s.SerializeObject<Placeholder>(characterskillsloc, name: "characterskillsloc");
			characteridmap = s.SerializeObject<Placeholder>(characteridmap, name: "characteridmap");
			characternames = s.SerializeObject<Placeholder>(characternames, name: "characternames");
		}
		public override uint? ClassCRC => 0x593E789E;
	}
}

