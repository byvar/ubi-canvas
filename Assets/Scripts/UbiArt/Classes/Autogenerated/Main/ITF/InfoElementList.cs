using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
	public partial class InfoElementList : CSerializable {
		public CList<InfoElement> elements;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			elements = s.SerializeObject<CList<InfoElement>>(elements, name: "elements");
		}
	}
}

