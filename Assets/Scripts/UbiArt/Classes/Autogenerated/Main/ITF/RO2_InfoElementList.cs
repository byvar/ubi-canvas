using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_InfoElementList : CSerializable {
		public CListO<RO2_InfoElement> elements;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			elements = s.SerializeObject<CListO<RO2_InfoElement>>(elements, name: "elements");
		}
	}
}

