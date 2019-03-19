using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_BubblePrize_Template : CSerializable {
		[Serialize("CList<BubblePrizeContent_Template>__0")] public CList<BubblePrizeContent_Template> CList_BubblePrizeContent_Template__0;
		[Serialize("float__1"                             )] public float float__1;
		[Serialize("int__2"                               )] public int int__2;
		[Serialize("int__3"                               )] public int int__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CList_BubblePrizeContent_Template__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(int__2));
			SerializeField(s, nameof(int__3));
		}
	}
}

