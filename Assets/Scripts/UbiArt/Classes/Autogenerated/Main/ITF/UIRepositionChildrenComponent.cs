using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class UIRepositionChildrenComponent : UIItem {
		[Serialize("spaceBetweenChildren")] public int spaceBetweenChildren;
		[Serialize("verticalOffset"      )] public int verticalOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spaceBetweenChildren));
			SerializeField(s, nameof(verticalOffset));
		}
		public override uint? ClassCRC => 0xB4A5EA86;
	}
}

