using UnityEngine;

namespace UbiArt.ITF {
	public partial class RenderSingleAnimData : SingleAnimData {
		[Serialize("xMin" )] public float xMin;
		[Serialize("yMin" )] public float yMin;
		[Serialize("state")] public uint state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(xMin));
			SerializeField(s, nameof(yMin));
			SerializeField(s, nameof(state));
		}
		public override uint? ClassCRC => 0xAD846A09;
	}
}

