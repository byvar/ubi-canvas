using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_LevelSpotComponent_Template : Ray_WM_SpotComponent_Template {
		public StringID textCageID;
		public StringID textCoinID;
		public StringID textLumID;
		public StringID textTimeID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			textCageID = s.SerializeObject<StringID>(textCageID, name: "textCageID");
			textCoinID = s.SerializeObject<StringID>(textCoinID, name: "textCoinID");
			textLumID = s.SerializeObject<StringID>(textLumID, name: "textLumID");
			textTimeID = s.SerializeObject<StringID>(textTimeID, name: "textTimeID");
		}
		public override uint? ClassCRC => 0x27368CDF;
	}
}

