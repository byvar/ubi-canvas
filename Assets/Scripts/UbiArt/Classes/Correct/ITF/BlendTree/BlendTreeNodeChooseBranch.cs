using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeChooseBranch<T> : BlendTreeNodeBlend<T> {
		[Serialize("childData")] public CList<BlendLeaf> childData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(childData));
		}
		public override uint? ClassCRC => 0xA91EE61E;
		
		[Games(GameFlags.All)]
		public partial class BlendLeaf : CSerializable {
			[Serialize("criterias")] public CList<Criteria> criterias;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(criterias));
			}
		}
	}
}

