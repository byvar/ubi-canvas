using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_InfoElementList : CSerializable {
		public CList<RO2_InfoElement> elements;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			elements = s.SerializeObject<CList<RO2_InfoElement>>(elements, name: "elements");
		}
	}
}

