using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeBlendBranches_Template<T> : BlendTreeNodeBlend_Template<T> {
		[Serialize("blendParams"                )] public CList<BlendLeaf> blendParams;
		[Serialize("blendInput"                 )] public StringID blendInput;
		[Serialize("blendInputInterpolation"    )] public float blendInputInterpolation;
		[Serialize("blendInputInterpoStartValue")] public float blendInputInterpoStartValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(blendParams));
			SerializeField(s, nameof(blendInput));
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(blendInputInterpolation));
				SerializeField(s, nameof(blendInputInterpoStartValue));
			}
		}
		public override uint? ClassCRC => 0xC1143887;

		[Games(GameFlags.All)]
		public partial class BlendLeaf : CSerializable {
			[Serialize("blendParam")] public float blendParam;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(blendParam));
			}
		}
	}
}

