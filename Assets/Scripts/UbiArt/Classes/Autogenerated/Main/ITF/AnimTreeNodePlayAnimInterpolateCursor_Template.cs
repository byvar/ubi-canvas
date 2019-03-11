using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTreeNodePlayAnimInterpolateCursor_Template : AnimTreeNodePlayAnim_Template {
		[Serialize("interpolationTime")] public float interpolationTime;
		[Serialize("startCursor"      )] public float startCursor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(interpolationTime));
			SerializeField(s, nameof(startCursor));
		}
		public override uint? ClassCRC => 0x93FBE508;
	}
}

