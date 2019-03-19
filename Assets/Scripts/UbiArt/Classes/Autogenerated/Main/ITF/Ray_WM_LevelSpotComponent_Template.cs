using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_LevelSpotComponent_Template : Ray_WM_SpotComponent_Template {
		[Serialize("textCageID")] public StringID textCageID;
		[Serialize("textCoinID")] public StringID textCoinID;
		[Serialize("textLumID" )] public StringID textLumID;
		[Serialize("textTimeID")] public StringID textTimeID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(textCageID));
			SerializeField(s, nameof(textCoinID));
			SerializeField(s, nameof(textLumID));
			SerializeField(s, nameof(textTimeID));
		}
		public override uint? ClassCRC => 0x27368CDF;
	}
}

