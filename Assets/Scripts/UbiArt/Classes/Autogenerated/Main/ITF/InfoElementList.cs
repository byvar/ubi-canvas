using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
	public partial class InfoElementList : CSerializable {
		public CListO<InfoElement> elements;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			elements = s.SerializeObject<CListO<InfoElement>>(elements, name: "elements");
		}
	}
}

